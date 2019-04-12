using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string originPath = "image";
        string genPath = "gen";
        string name = "";

        GeneticManager manager;

        public Form1()
        {
            InitializeComponent();
        }

        void ConvGrayscale(Bitmap bmp)
        {
            Color p;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    
                    int avg = (r + g + b) / 3;
                    
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            name = textName.Text;

            if (File.Exists(textLoadPath.Text))
            {
                var image = new Bitmap(Image.FromFile(textLoadPath.Text), Global.OriginImageSize);

                var ext = Path.GetExtension(textLoadPath.Text);

                var path = Path.Combine(Application.StartupPath, originPath, name);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, $"origin.{ext}");

                Global.GrayScale = optionGrayScale.Checked;

                if (optionGrayScale.Checked)
                {
                    ConvGrayscale(image);
                }

                image.Save(path);

                picOrigin.Image = image;

                
            }
            else
            {
                MessageBox.Show("Check File Exsts!!");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textCount.Text, out int count) && double.TryParse(textMutation.Text, out double mutation)
                 && int.TryParse(textSurvive.Text, out int survive) && int.TryParse(textCrossCount.Text, out int cross))
            {
                manager = new GeneticManager(new Bitmap(picOrigin.Image), count, mutation, survive, cross);
                manager.BestGenImage += Manager_BestGenImage;
                manager.Run();
            }
        }



        private void Manager_BestGenImage(object sender, (Bitmap, int) e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var path = Path.Combine(Application.StartupPath, genPath, name);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                e.Item1.Save(Path.Combine(path, $"{e.Item2}.png"));

                StreamWriter sw = new StreamWriter(textResult.Text, true, Encoding.UTF8);
                sw.WriteLine($"{e.Item2}, {DistanceScore(e.Item1, new Bitmap(picOrigin.Image, 256,256))}");
                sw.Close();

                Bitmap result = e.Item1;

                if (optionMedianFilter.Checked)
                {
                    MedianFiltering(result);
                    result.Save(Path.Combine(path, $"{e.Item2}_Median.png"));
                }

                picGenetic.Image = e.Item1;
                labelGenCount.Text = e.Item2.ToString();
            }));
        }

        public static void MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width, bm.Height];

            //Convert to Grayscale 
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            //applying Median Filtering 
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

        public long DistanceScore(Bitmap a, Bitmap b)
        {
            long result = 0;
            for (int h = 0; h < 256; h++)
            {
                for (int w = 0; w < 256; w++)
                {
                    var t = Math.Abs(a.GetPixel(w, h).R - b.GetPixel(w, h).R);
                    result += (t * t);
                }
            }
            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var p = new Bitmap(picOrigin.Image);
            MedianFiltering(p);
            p.Save(textResult.Text);

        }
    }
}
