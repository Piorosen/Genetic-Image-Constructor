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

        public static long DistanceScore(int[,] Gen, int[,] gen)
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
        public static long DistanceScore(Genetic Gen, Genetic gen)
        {
            return DistanceScore(Gen.Gen, gen.Gen);
        }


        public Genetic(int[,] gen)
        {
            Gen = gen.Clone() as int[,];
        }
        public Genetic(Genetic gen)
        {
            Gen = gen.Gen.Clone() as int[,];
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
                    var avg = rand.Next(byte.MinValue, byte.MaxValue + 1);
                    Gen[h, w] = avg;
                }
            }
        }

        /// <summary>
        /// genetic Average value
        /// </summary>
        /// <param name="gen">another genetic</param>
        private static Genetic[] Cross(int[,] Gen, int[,] gen)
        {
            int pos = rand.Next(0, Width) + rand.Next(0, Height) * Width;

            Genetic[] result = new Genetic[2]
            {
                new Genetic(),
                new Genetic()
            };
            CrossType t = Global.CrossType;

            if (Global.CrossType == CrossType.Random)
            {
                if (rand.NextDouble() > 0.5)
                {
                    t = CrossType.Vertical;
                }
                else
                {
                    t = CrossType.Horizontal;
                }
            }

            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    int a = h, b = w;
                    if (t == CrossType.Vertical)
                    {
                        a = w;
                        b = h;
                    }

                    if (h * Width + w < pos)
                    {
                        result[0].Gen[a, b] = Gen[a, b];
                        result[1].Gen[a, b] = gen[a, b];
                    }
                    else
                    {
                        result[1].Gen[a, b] = Gen[a, b];
                        result[0].Gen[a, b] = gen[a, b];
                    }
                }
            }
            return result;
        }

        public static Genetic[] Cross(Genetic Gen, Genetic gen)
        {
            return Cross(Gen.Gen, gen.Gen);
        }

        /// <summary>
        /// genetic Mutation
        /// </summary>
        /// <param name="rate">rate is 0.00 ~ 1.00</param>
        public void Mutation(double rate)
        {
            if (rate >= rand.NextDouble())
            {
                int count = rand.Next(1, Global.MutationMaxCount);

                for (int i = 0; i < count; i++)
                {
                    int y = rand.Next(Global.MutationPointSize, Height - Global.MutationPointSize);
                    int x = rand.Next(Global.MutationPointSize, Width - Global.MutationPointSize);

                    if (Global.MutationOver)
                    {
                        y = rand.Next(0, Height);
                        x = rand.Next(0, Width);
                    }
                   
                    int value = rand.Next(byte.MinValue, byte.MaxValue + 1);
                    for (int h = -Global.MutationPointSize + y; h < 1 + y + Global.MutationPointSize; h++)
                    {
                        for (int w = -Global.MutationPointSize + x; w < 1 + x + Global.MutationPointSize; w++)
                        {
                            if (0 <= h && h < Height
                                       && 0 <= w && w < Width)
                            {
                                if (Global.MutationRangeRandom)
                                {
                                    Gen[h, w] = rand.Next(byte.MinValue, byte.MaxValue + 1);
                                }
                                else
                                {
                                    Gen[h, w] = value;
                                }
                            }
                        }
                    }
                }
            }
            #region Comment
            //for (int h = 0; h < Height; h++)
            //{
            //    for (int w = 0; w < Width; w++)
            //    {
            //        if (rate >= rand.NextDouble())
            //        {
            //            int count = rand.Next(1, Global.MutationMaxCount);
            //            for (int i = 0; i < count; i++)
            //            {
            //                int y = rand.Next(0, Height);
            //                int x = rand.Next(0, Width);
            //                Gen[y,x] = rand.Next(byte.MinValue, byte.MaxValue + 1);
            //            }
            //            //for (int y = -Global.MutationPointSize + h; y < 1 + h + Global.MutationPointSize; y++)
            //            //{
            //            //    for (int x = -Global.MutationPointSize + w; x < 1 + w + Global.MutationPointSize; x++)
            //            //    {
            //            //        if (0 <= y && y < Height
            //            //            && 0 <= x && x < Width)
            //            //        {
            //            //            Gen[y, x] = rand.Next(byte.MinValue, byte.MaxValue);
            //            //        }
            //            //    }
            //            //}
            //        }
            //    }
            //}
            #endregion
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
