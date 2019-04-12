using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GeneticImage
    {
        public event EventHandler<(Bitmap, Point)> BestGenImage;

        List<Genetic> Gray = new List<Genetic>();
        List<Genetic> Red = new List<Genetic>();
        List<Genetic> Green = new List<Genetic>();
        List<Genetic> Blue = new List<Genetic>();

        List<int[,]> ColorList = new List<int[,]>();

        Point position = new Point();
        public GeneticImage(Bitmap image, Point pos)
        {
            var Origin = new Genetic(image);
            ColorList.Add(Origin.ConvertColor(ColorType.GRAY));
            ColorList.Add(Origin.ConvertColor(ColorType.RED));
            ColorList.Add(Origin.ConvertColor(ColorType.GREEN));
            ColorList.Add(Origin.ConvertColor(ColorType.BLUE));

            position = pos;

            if (Global.GrayScale == true)
            {
                for (int i = 0; i < Global.Count; i++)
                {
                    Gray.Add(new Genetic());
                }
            }
            else
            {
                for (int i = 0; i < Global.Count; i++)
                {
                    Red.Add(new Genetic());
                    Green.Add(new Genetic());
                    Blue.Add(new Genetic());
                }
            }
            
        }
        
        private Bitmap GenerateBitmap()
        {
            Bitmap image = new Bitmap(Genetic.Width, Genetic.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if (Global.GrayScale == true)
                    {
                        image.SetPixel(x, y, Color.FromArgb(Byte.MaxValue, Gray[0].Gen[y, x]
                                                                        , Gray[0].Gen[y, x]
                                                                        , Gray[0].Gen[y, x]));
                    }
                    else
                    {
                        image.SetPixel(x, y, Color.FromArgb(byte.MaxValue, Red[0].Gen[y, x]
                                                                    , Green[0].Gen[y, x]
                                                                    , Blue[0].Gen[y, x]));
                    }
                    
                }
            }
            return image;
        }


        public void Run()
        {
            if (Global.GrayScale == true)
            {
                GeneticSort(0, Gray);
            }
            else
            {
                GeneticSort(1, Red, Green, Blue);
            }
            
            BestGenImage?.Invoke(this, (GenerateBitmap(), position));

            NextGen();
            
        }

        private void GeneticSort(int start, params List<Genetic>[] data)
        {
            foreach(var value in data)
            {
                value.Sort((a, b) => Genetic.DistanceScore(a.Gen, ColorList[start]) < Genetic.DistanceScore(b.Gen, ColorList[start])
                                     ? -1 : 1);
                start++;
            }
        }

        /// <summary>
        /// 이전이름 : Survive
        /// </summary>
        private void NextGen()
        {
            if (Global.GrayScale == true)
            {
                Gray = CrossGenetic(Gray);
            }
            else
            {
                Red = CrossGenetic(Red);
                Blue = CrossGenetic(Blue);
                Green = CrossGenetic(Green);
            }

            Mutation();

            #region Comment
            //for (int e = Global.Count - 1; e >= Global.Survive; e--)
            //{
            //    if (Global.GrayScale == true)
            //    {
            //        Gray.RemoveAt(e);
            //    }
            //    else
            //    {
            //        Red.RemoveAt(e);
            //        Green.RemoveAt(e);
            //        Blue.RemoveAt(e);
            //    }
            //}
            //var rate = ((double)(Global.Count - Global.Survive) / (double)Global.Survive);
            //for (int y = 0; y < Global.Survive; y++)
            //{
            //    for (int i = 0; i < rate; i++)
            //    {
            //        if (Global.GrayScale == true)
            //        {
            //            Gray.Add(new Genetic(Gray[y].Gen));
            //        }
            //        else
            //        {
            //            Red.Add(new Genetic(Red[y]));
            //            Green.Add(new Genetic(Green[y]));
            //            Blue.Add(new Genetic(Blue[y]));
            //        }
            //    }
            //}
            //if (Global.GrayScale == true)
            //{
            //    for (int i = Gray.Count; i < Global.Count; i++)
            //    {
            //        Gray.Add(new Genetic(Gray[Global.Survive - 1].Gen));
            //    }
            //}
            //else
            //{
            //    for (int i = Red.Count; i < Global.Count; i++)
            //    {
            //        Red.Add(new Genetic(Red[Global.Survive - 1].Gen));
            //        Green.Add(new Genetic(Green[Global.Survive - 1].Gen));
            //        Blue.Add(new Genetic(Blue[Global.Survive - 1].Gen));
            //    }
            //}
            #endregion
        }

        private List<Genetic> CrossGenetic(List<Genetic> gen)
        {
            var result = new List<Genetic>();

            for (int i = 0; i < Global.EliteSurvive; i++)
            {
                result.Add(gen[i]);
            }
            result.AddRange(Genetic.Cross(gen[0], gen[2]));
            result.AddRange(Genetic.Cross(gen[0], gen[5]));
            result.AddRange(Genetic.Cross(gen[0], gen[10]));
            result.AddRange(Genetic.Cross(gen[0], gen[18]));
            result.AddRange(Genetic.Cross(gen[0], gen[27]));
            result.AddRange(Genetic.Cross(gen[0], gen[40]));

            result.AddRange(Genetic.Cross(gen[1], gen[4]));
            result.AddRange(Genetic.Cross(gen[1], gen[11]));
            result.AddRange(Genetic.Cross(gen[1], gen[20]));
            result.AddRange(Genetic.Cross(gen[1], gen[30]));
            result.AddRange(Genetic.Cross(gen[1], gen[45]));

            result.AddRange(Genetic.Cross(gen[2], gen[7]));
            result.AddRange(Genetic.Cross(gen[2], gen[13]));
            result.AddRange(Genetic.Cross(gen[2], gen[23]));
            result.AddRange(Genetic.Cross(gen[2], gen[43]));

            result.AddRange(Genetic.Cross(gen[4], gen[17]));
            result.AddRange(Genetic.Cross(gen[4], gen[28]));
            result.AddRange(Genetic.Cross(gen[4], gen[34]));

            result.AddRange(Genetic.Cross(gen[9], gen[15]));
            result.AddRange(Genetic.Cross(gen[9], gen[24]));
            result.AddRange(Genetic.Cross(gen[9], gen[36]));

            result.AddRange(Genetic.Cross(gen[14], gen[34]));
            result.AddRange(Genetic.Cross(gen[14], gen[46]));

            result.AddRange(Genetic.Cross(gen[19], gen[48]));

            #region Comment
            //for (int i = 0; i < Global.EliteSurvive; i++)
            //{
            //    for (int g = 0; g < gen.Count; g += i + 2)
            //    {
            //        result.AddRange(Genetic.Cross(gen[g], gen[i]));
            //    }
            //    if (result.Count > Global.Count)
            //    {
            //        while (result.Count > Global.Count)
            //        {
            //            result.RemoveAt(Global.Count);
            //        }
            //        break;
            //    }
            //}
            #endregion
           
            return result;
        }

        private void Mutation()
        {
            for (int i = Global.EliteSurvive; i < Global.Count; i++)
            {
                if (Global.GrayScale == true)
                {
                    Gray[i].Mutation(Global.Mutation);
                }
                else
                {
                    Red[i].Mutation(Global.Mutation);
                    Green[i].Mutation(Global.Mutation);
                    Blue[i].Mutation(Global.Mutation);
                }
            }
        }
    }
}
