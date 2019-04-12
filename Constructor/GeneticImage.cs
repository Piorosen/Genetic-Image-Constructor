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

        readonly List<Genetic> Gray = new List<Genetic>();
        readonly List<Genetic> Red = new List<Genetic>();
        readonly List<Genetic> Green = new List<Genetic>();
        readonly List<Genetic> Blue = new List<Genetic>();

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

            for (int i = 0; i < Global.Count; i++)
            {
                if (Global.GrayScale == true)
                {
                    Gray.Add(new Genetic());
                }
                else
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
                Gray.Sort((a, b) => a.DistanceScore(ColorList[0]) < b.DistanceScore(ColorList[0])
                                     ? -1 : 1);
            }
            else
            {
                Red.Sort((a, b) => a.DistanceScore(ColorList[1]) < b.DistanceScore(ColorList[1])
                                     ? -1 : 1);
                Green.Sort((a, b) => a.DistanceScore(ColorList[2]) < b.DistanceScore(ColorList[2])
                                         ? -1 : 1);
                Blue.Sort((a, b) => a.DistanceScore(ColorList[3]) < b.DistanceScore(ColorList[3])
                                         ? -1 : 1);
            }
            

            BestGenImage?.Invoke(this, (GenerateBitmap(), position));

            Survive();
            CrossGenetic();
            Mutation();
        }

        private void Survive()
        {
            for (int e = Global.Count - 1; e >= Global.Survive; e--)
            {
                if (Global.GrayScale == true)
                {
                    Gray.RemoveAt(e);
                }
                else
                {
                    Red.RemoveAt(e);
                    Green.RemoveAt(e);
                    Blue.RemoveAt(e);
                }
            }

            var rate = ((double)(Global.Count - Global.Survive) / (double)Global.Survive);

            for (int y = 0; y < Global.Survive; y++)
            {
                for (int i = 0; i < rate; i++)
                {
                    if (Global.GrayScale == true)
                    {
                        Gray.Add(new Genetic(Gray[y].Gen));
                    }
                    else
                    {
                        Red.Add(new Genetic(Red[y].Gen));
                        Green.Add(new Genetic(Green[y].Gen));
                        Blue.Add(new Genetic(Blue[y].Gen));
                    }
                }
            }
            if (Global.GrayScale == true)
            {
                for (int i = Gray.Count; i < Global.Count; i++)
                {
                    Gray.Add(new Genetic(Gray[Global.Survive - 1].Gen));
                }
            }
            else
            {
                for (int i = Red.Count; i < Global.Count; i++)
                {
                    Red.Add(new Genetic(Red[Global.Survive - 1].Gen));
                    Green.Add(new Genetic(Green[Global.Survive - 1].Gen));
                    Blue.Add(new Genetic(Blue[Global.Survive - 1].Gen));
                }
            }
        }

        private void CrossGenetic()
        {
            for (int i = 0; i < Global.CrossCount; i++)
            {
                if (Global.GrayScale == true)
                {
                    for (int g = 0; g < Gray.Count; g += i + 1)
                    {
                        Gray[g].Cross(Gray[i]);
                    }
                }
                else
                {
                    for (int g = 0; g < Red.Count; g += i + 1)
                    {
                        Red[g].Cross(Red[i]);
                        Green[g].Cross(Green[i]);
                        Blue[g].Cross(Blue[i]);
                    }
                }                
            }
        }

        private void Mutation()
        {
            for (int i = 0; i < Global.Count; i++)
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
