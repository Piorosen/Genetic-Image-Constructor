using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Genetic
    {
        public static Random rand = new Random();
        public static int Height => Global.OriginImageSize.Height / Global.GeneticCutCount.Height;
        public static int Width => Global.OriginImageSize.Width / Global.GeneticCutCount.Width;

        public int[,] Gen = new int[Height, Width];

        public long DistanceScore(int[,] gen)
        {
            long result = 0;
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    var r = Math.Abs(Gen[h, w] - gen[h, w]);

                    result += r * r;
                }
            }
            return result;
        }

        public Genetic(int[,] gen)
        {
            Gen = gen.Clone() as int[,];
        }

        public Genetic(Bitmap image)
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    var color = image.GetPixel(w, h);
                    Gen[h, w] = Color.FromArgb(byte.MaxValue, color).ToArgb();
                }
            }
        }

        public Genetic()
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    var avg = rand.Next(byte.MinValue, byte.MaxValue);
                    Gen[h, w] = avg;
                }
            }
        }

        /// <summary>
        /// genetic Average value
        /// </summary>
        /// <param name="gen">another genetic</param>
        public void Cross(int[,] gen)
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    int value = (Gen[h, w] + gen[h, w]) / 2;

                    Gen[h, w] = value;
                }
            }
        }
        public void Cross(Genetic gen)
        {
            Cross(gen.Gen);
        }

        /// <summary>
        /// genetic Mutation
        /// </summary>
        /// <param name="rate">rate is 0.00 ~ 1.00</param>
        public void Mutation(double rate)
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    if (rate >= rand.NextDouble())
                    {
                        for (int y = -Global.MutationPointSize + h; y < 1 + h + Global.MutationPointSize; y++)
                        {
                            for (int x = -Global.MutationPointSize + w; x < 1 + w + Global.MutationPointSize; x++)
                            {
                                if (0 <= y && y < Height
                                    && 0 <= x && x < Width)
                                {
                                    Gen[y, x] = rand.Next(byte.MinValue, byte.MaxValue);
                                }
                            }
                        }
                    }
                }
            }
        }


        public int[,] ConvertColor(ColorType type)
        {
            int[,] result = new int[Height, Width];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    switch (type)
                    {
                        case ColorType.RED:
                            result[y, x] = (Gen[y, x] & 0x00_ff_00_00) >> 16 & 0xff;
                            break;
                        case ColorType.GREEN:
                            result[y, x] = (Gen[y, x] & 0x00_00_ff_00) >> 8 & 0xff;
                            break;
                        case ColorType.BLUE:
                            result[y, x] = (Gen[y, x] & 0x00_00_00_ff) & 0xff;
                            break;
                        case ColorType.GRAY:
                            result[y, x] = (Gen[y, x] & 0x00_00_00_ff) & 0xff;

                            break;
                    }
                }
            }
            return result;
        }
    }
}
