using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GeneticManager
    {
        public event EventHandler<(Bitmap, int)> BestGenImage;

        private List<GeneticImage> GenImage = new List<GeneticImage>();

        int _genCount = 0;
        int GenCount
        {
            get
            {
                _genCount++;
                return _genCount;
            }
        }

        public GeneticManager(Bitmap origin)
        {
            for (int by = 0; by < Global.GeneticCutCount.Height; by++)
            {
                for (int bx = 0; bx < Global.GeneticCutCount.Width; bx++)
                {
                    Bitmap image = new Bitmap(Global.OriginImageSize.Width / Global.GeneticCutCount.Width,
                                                Global.OriginImageSize.Height / Global.GeneticCutCount.Height);

                    var start = new Point(bx * image.Width, by * image.Height);

                    for (int y = 0; y < image.Height; y++)
                    {
                        for (int x = 0; x < image.Width; x++)
                        {
                            image.SetPixel(x, y, origin.GetPixel(x + start.X, y + start.Y));
                        }
                    }

                    GenImage.Add(new GeneticImage(image, new Point(bx, by)));
                    GenImage[GenImage.Count - 1].BestGenImage += Value_BestGenImage;
                    result[by, bx] = new Queue<Bitmap>();
                }
            }
        }

        public void Run()
        {
            Task.Run(() =>
            {
                for (int i = 0; ; i++)
                {
                    for (int y = 0; y < Global.GeneticCutCount.Height; y++)
                    {
                        for (int x = 0; x < Global.GeneticCutCount.Width; x++)
                        {
                            GenImage[y * Global.GeneticCutCount.Width + x].Run();
                        }
                    }

                    BestImage();
                }
            });
        }

        void BestImage()
        {
            int ty = Global.OriginImageSize.Height / Global.GeneticCutCount.Height;
            int tx = Global.OriginImageSize.Width / Global.GeneticCutCount.Width;

            var image = new Bitmap(Global.OriginImageSize.Width, Global.OriginImageSize.Height);

            for (int y = 0; y < Global.GeneticCutCount.Height; y++)
            {
                for (int x = 0; x < Global.GeneticCutCount.Width; x++)
                {
                    var p = result[y, x].Dequeue();        
                    var start = new Point(x * tx, y * ty);

                    for (int by = start.Y; by < start.Y + ty; by++)
                    {
                        for (int bx = start.X; bx < start.X + tx; bx++)
                        {
                            image.SetPixel(bx, by, p.GetPixel(bx - start.X, by - start.Y));
                        }
                    }
                }
            }
            BestGenImage?.Invoke(this, (image, GenCount));
        }

        Queue<Bitmap>[,] result = new Queue<Bitmap>[Global.GeneticCutCount.Height, Global.GeneticCutCount.Width];

        private void Value_BestGenImage(object sender, (Bitmap image, Point p) e)
        {
            result[e.p.Y, e.p.X].Enqueue(e.image);
        }
    }
}
