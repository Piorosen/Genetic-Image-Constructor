using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using WindowsFormsApp1;

namespace Core
{
    class Program
    {
        static void Setting()
        {
            Console.WriteLine($"원본 해상도 변경 기본값 ({Global.OriginImageSize}): ");
            var originSize = Console.ReadLine().Split(" ");

            int r1 = 0;

            if (originSize.Length == 2)
            {
                int x = int.TryParse(originSize[0], out r1) ? r1 : Global.OriginImageSize.Width;
                int y = int.TryParse(originSize[1], out r1) ? r1 : Global.OriginImageSize.Height;

                Global.OriginImageSize = new Size(x, y);
            }
            

            Console.WriteLine($"자를 횟수 기본값 ({Global.GeneticCutCount}) : ");
            originSize = Console.ReadLine().Split(" ");
            if (originSize.Length == 2)
            {
                int x = int.TryParse(originSize[0], out r1) ? r1 : Global.GeneticCutCount.Width;
                int y = int.TryParse(originSize[1], out r1) ? r1 : Global.GeneticCutCount.Height;
                Global.GeneticCutCount = new Size(x, y);
            }

            Console.WriteLine($"교배 타입 ({Global.CrossType}) (1 : Vertical, 2 : Horizontal, 4 : Random) : ");
            Global.CrossType = int.TryParse(Console.ReadLine(), out r1) ? (CrossType)r1 : Global.CrossType;

            Console.WriteLine($"GrayScale로 변경 유무 기본값 ({Global.GrayScale}) : ");
            Global.GrayScale = bool.TryParse(Console.ReadLine(), out bool r) ? r : Global.GrayScale;

            Console.WriteLine($"개체 수 기본값 ({Global.Count}) : ");
            Global.Count = int.TryParse(Console.ReadLine(), out r1) ? r1 : Global.Count;

            Console.WriteLine($"변이 확률 기본값 ({Global.Mutation}) : ");
            Global.Mutation = double.TryParse(Console.ReadLine(), out double r2) ? r2 : Global.Mutation;

            Console.WriteLine($"교배 수 기본값 ({Global.EliteSurvive}) : ");
            Global.EliteSurvive = int.TryParse(Console.ReadLine(), out r1) ? r1 : Global.EliteSurvive;

            
        }

        static string path;
        static string savePath;
        static string csvPath;
        static Bitmap Origin;
        
        static bool median = false;
        static void Main(string[] args)
        {
            Console.WriteLine($"원본 이미지 주소 : ");
            path = Console.ReadLine();

            Console.WriteLine("유전자 이미지 저장할 경로 : ");
            savePath = Console.ReadLine();

            Console.WriteLine("유전자 csv 파일 저장할 경로 : ");
            csvPath = Console.ReadLine();

            Setting();

            Origin = ImageConv(path);

            GeneticManager genetic = new GeneticManager(Origin);
            genetic.BestGenImage += Genetic_BestGenImage;
            genetic.Run();

            for (; ; )
            {
                median = bool.TryParse(Console.ReadLine(), out bool r) ? r : median;
                Console.WriteLine($"Median 값 : {median} 으로 변경됨.");
            }
        }

        static Bitmap ImageConv(string image)
        {
            Bitmap result = new Bitmap(Image.FromFile(image), Global.OriginImageSize);

            if (Global.GrayScale)
            {
                ConvGrayscale(result);
            }

            result.Save(Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path)) + "_conv.png");

            return result;
        }

        static void ConvGrayscale(Bitmap bmp)
        {
            Color p;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }
        }

        private static void Genetic_BestGenImage(object sender, (Bitmap, int) e)
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            e.Item1.Save(Path.Combine(savePath, $"{e.Item2}.png"));

            StreamWriter sw = new StreamWriter(csvPath, true, Encoding.UTF8);
            sw.WriteLine($"{e.Item2}, {DistanceScore(Origin, new Bitmap(e.Item1, Global.OriginImageSize))}");
            sw.Close();

            Bitmap result = e.Item1;

            Console.WriteLine($"{e.Item2} 세대 진행 완료");
           

            if (median)
            {
                MedianFiltering(result);
                Console.WriteLine($"{e.Item2} 세대 MedianFilter 적용 완료");
                result.Save(Path.Combine(savePath, $"{e.Item2}_Median.png"));
            }
        }

        static void MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            termsList.Add(image[x, y]);
                        }
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort<byte>(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }
        }

        static long DistanceScore(Bitmap a, Bitmap b)
        {
            var a1 = new Genetic(a);
            var b1 = new Genetic(b);

            var result = 0L;

            if (Global.GrayScale)
            {
                result = Genetic.DistanceScore(a1.ConvertColor(ColorType.GRAY), b1.ConvertColor(ColorType.GRAY));
            }
            else
            {
                result += Genetic.DistanceScore(a1.ConvertColor(ColorType.RED), b1.ConvertColor(ColorType.RED));
                result += Genetic.DistanceScore(a1.ConvertColor(ColorType.BLUE), b1.ConvertColor(ColorType.BLUE));
                result += Genetic.DistanceScore(a1.ConvertColor(ColorType.GREEN), b1.ConvertColor(ColorType.GREEN));
            }
            
            Console.WriteLine($"{result}");
            return result;
        }
    }
}
