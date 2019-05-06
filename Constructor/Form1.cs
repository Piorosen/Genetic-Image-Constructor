using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Status
        {
            set
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    label_status.Text = $"Status : {value}";
                }));
                
            }
        }

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


        private void find_Click(object sender, EventArgs e)
        {
            Status = "find file...";
            var tmp = (sender as Control).Name.Split('_')[1];
            string result = string.Empty;
            if (tmp == "savefolder")
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    result = fbd.SelectedPath;
                }
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    result = ofd.FileName;
                }
            }
            string name = "text_" + tmp;

            var obj = GetType().GetField(name, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
            obj.GetType().GetProperty("Text").SetValue(obj, result);

            Status = "find";
        }

        private void Btn_settingsave_Click(object sender, EventArgs e)
        {
            Status = "Base Conf Save...";
            Config.SetOption("Base Conf", "image", text_image.Text);
            Config.SetOption("Base Conf", "savefolder", text_savefolder.Text);
            Config.SetOption("Base Conf", "csv", text_csv.Text);
            Config.SetOption("Base Conf", "bsave", check_save.Checked.ToString());
            Config.SetOption("Base Conf", "bmedian", check_median.Checked.ToString());
            Status = "Base Conf Save";
        }
        private void Btn_runsetsave_Click(object sender, EventArgs e)
        {
            Status = "execute setting save...";
            Config.SetOption("execute", "originsize", text_originsize.Text);
            Config.SetOption("execute", "cutsize", text_cutsize.Text);
            Config.SetOption("execute", "crosstype", text_crosstype.Text);
            Config.SetOption("execute", "grayscale", text_grayscale.Text);
            Config.SetOption("execute", "mutrange", text_mutrange.Text);

            Config.SetOption("execute", "mutoverchange", text_mutoverchange.Text);
            Config.SetOption("execute", "mutpointsize", text_mutsize.Text);
            Config.SetOption("execute", "mutmaxcount", text_mutmaxcount.Text);
            Config.SetOption("execute", "mutpercent", text_mutpercent.Text);
            Config.SetOption("execute", "elite", text_elite.Text);
            Status = "execute setting save";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Config.Path = Path.Combine(Application.StartupPath, "config.ini");

            if (File.Exists(Config.Path) == false)
            {
                Btn_settingsave_Click(null, null);
                Btn_runsetsave_Click(null, null);
            }

            text_image.Text = Config.GetOption("Base Conf", "image");
            text_savefolder.Text = Config.GetOption("Base Conf", "savefolder");
            text_csv.Text = Config.GetOption("Base Conf", "csv");

            check_save.Checked = bool.Parse(Config.GetOption("Base Conf", "bsave"));
            check_median.Checked = bool.Parse(Config.GetOption("Base Conf", "bmedian"));

            text_originsize.Text = Config.GetOption("execute", "originsize");
            text_cutsize.Text = Config.GetOption("execute", "cutsize");
            text_crosstype.Text = Config.GetOption("execute", "crosstype");
            text_grayscale.Text = Config.GetOption("execute", "grayscale");
            text_mutrange.Text = Config.GetOption("execute", "mutrange");

            text_mutoverchange.Text = Config.GetOption("execute", "mutoverchange");
            text_mutsize.Text = Config.GetOption("execute", "mutpointsize");
            text_mutmaxcount.Text = Config.GetOption("execute", "mutmaxcount");
            text_mutpercent.Text = Config.GetOption("execute", "mutpercent");
            text_elite.Text = Config.GetOption("execute", "elite");

        }

        private void Btn_run_Click(object sender, EventArgs e)
        {
            if (pic_origin.Image == null)
            {
                Status = "execute fail";
                MessageBox.Show("not found image");
            }
            else
            {
                Status = "execute";
                text_grayscale.Enabled = false;
                Global.Stop = false;

                GeneticManager gm = new GeneticManager(new Bitmap(pic_origin.Image));
                gm.BestGenImage += Gm_BestGenImage;
                gm.Run();
            }
        }

        object _lock = new object();
        private void Gm_BestGenImage(object sender, (Bitmap result, int gen) e)
        {
            lock (_lock)
            {
                Status = $"{e.gen} gen...";
                if (check_save.Checked)
                {
                    if (!Directory.Exists(text_savefolder.Text))
                    {
                        Directory.CreateDirectory(text_savefolder.Text);
                    }
                    e.result.Save(Path.Combine(text_savefolder.Text, $"{e.gen}.png"));

                    StreamWriter sw = new StreamWriter(text_csv.Text, true, Encoding.UTF8);
                    sw.WriteLine($"{e.gen}, {DistanceScore(new Bitmap(pic_origin.Image), e.result)}");
                    sw.Close();

                    Status = $"{e.gen} csv save";

                    if (check_median.Checked)
                    {
                        Status = $"{e.gen} median filter...";
                        MedianFiltering(e.result);
                        Status = $"{e.gen} median filter";
                        e.result.Save(Path.Combine(text_savefolder.Text, $"{e.gen}_Median.png"));
                    }
                }

                pic_bestsol.Image = e.result;


                Status = $"{e.gen} gen complete";

                if (Global.Stop)
                {
                    Status = "stop!";
                    this.Invoke(new MethodInvoker(() =>
                    {
                        text_grayscale.Enabled = true;
                    }));
                    
                }
            }
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                var image = new Bitmap(Image.FromFile(text_image.Text), Global.OriginImageSize); ;
                
                if (Global.GrayScale)
                {
                    ConvGrayscale(image);
                }

                if (check_save.Checked)
                {
                    image.Save(Path.Combine(Path.GetDirectoryName(text_image.Text), Path.GetFileNameWithoutExtension(text_image.Text)) + "_conv.png");
                }
                
                pic_origin.Image = image;
                Status = "setting apply";
            }
            catch
            {
                pic_origin.Image = null;
                Status = "setting apply fail";
                MessageBox.Show("not found image");
            }
        }

        private void Btn_runapply_Click(object sender, EventArgs e)
        {
            Status = "execute setting apply...";
            try
            {
                var size = text_originsize.Text.Split(',');
                Global.OriginImageSize = new Size(int.Parse(size[0].Trim('{', '}', ' ')), int.Parse(size[1].Trim('{', '}', ' ')));
                size = text_cutsize.Text.Split(',');
                Global.GeneticCutCount = new Size(int.Parse(size[0].Trim('{', '}', ' ')), int.Parse(size[1].Trim('{', '}', ' ')));
                Global.CrossType = (CrossType)int.Parse(text_crosstype.Text);
                Global.GrayScale = bool.Parse(text_grayscale.Text);

                Global.MutationPointSize = int.Parse(text_mutsize.Text);
                Global.MutationRangeRandom = bool.Parse(text_mutrange.Text);

                Global.MutationMaxCount = int.Parse(text_mutmaxcount.Text);
                Global.MutationOver = bool.Parse(text_mutoverchange.Text);
                Global.Mutation = double.Parse(text_mutpercent.Text);

                Global.EliteSurvive = int.Parse(text_elite.Text);
                Status = "execute setting apply";
            }
            catch
            {
                MessageBox.Show("check your setting");
                Status = "execute setting fail";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Global.Stop = true;
            Status = "stop...";
        }



        long DistanceScore(Bitmap a, Bitmap b)
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
