namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_image = new System.Windows.Forms.TextBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.text_savefolder = new System.Windows.Forms.TextBox();
            this.btn_savefolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_csv = new System.Windows.Forms.Button();
            this.text_csv = new System.Windows.Forms.TextBox();
            this.check_save = new System.Windows.Forms.CheckBox();
            this.pic_origin = new System.Windows.Forms.PictureBox();
            this.btn_settingsave = new System.Windows.Forms.Button();
            this.pic_bestsol = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_originsize = new System.Windows.Forms.TextBox();
            this.btn_runsetsave = new System.Windows.Forms.Button();
            this.btn_runapply = new System.Windows.Forms.Button();
            this.text_cutsize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_crosstype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_grayscale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_mutrange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_mutoverchange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_elite = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_mutpercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_mutmaxcount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_mutsize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.check_median = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_origin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bestsol)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_image
            // 
            this.text_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_image.Location = new System.Drawing.Point(6, 335);
            this.text_image.Name = "text_image";
            this.text_image.Size = new System.Drawing.Size(296, 21);
            this.text_image.TabIndex = 0;
            this.text_image.Text = "..\\test.jpg";
            // 
            // btn_image
            // 
            this.btn_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_image.Location = new System.Drawing.Point(308, 333);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(37, 23);
            this.btn_image.TabIndex = 1;
            this.btn_image.Text = "find";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.find_Click);
            // 
            // text_savefolder
            // 
            this.text_savefolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_savefolder.Location = new System.Drawing.Point(6, 420);
            this.text_savefolder.Name = "text_savefolder";
            this.text_savefolder.Size = new System.Drawing.Size(296, 21);
            this.text_savefolder.TabIndex = 2;
            this.text_savefolder.Text = "..\\run";
            // 
            // btn_savefolder
            // 
            this.btn_savefolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_savefolder.Location = new System.Drawing.Point(308, 418);
            this.btn_savefolder.Name = "btn_savefolder";
            this.btn_savefolder.Size = new System.Drawing.Size(37, 23);
            this.btn_savefolder.TabIndex = 3;
            this.btn_savefolder.Text = "find";
            this.btn_savefolder.UseVisualStyleBackColor = true;
            this.btn_savefolder.Click += new System.EventHandler(this.find_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "image path";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "save folder path";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "csv path";
            // 
            // btn_csv
            // 
            this.btn_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_csv.Location = new System.Drawing.Point(306, 472);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(37, 23);
            this.btn_csv.TabIndex = 7;
            this.btn_csv.Text = "find";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.find_Click);
            // 
            // text_csv
            // 
            this.text_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_csv.Location = new System.Drawing.Point(4, 474);
            this.text_csv.Name = "text_csv";
            this.text_csv.Size = new System.Drawing.Size(296, 21);
            this.text_csv.TabIndex = 6;
            this.text_csv.Text = "..\\run\\result.csv";
            // 
            // check_save
            // 
            this.check_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_save.AutoSize = true;
            this.check_save.Checked = true;
            this.check_save.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_save.Location = new System.Drawing.Point(4, 377);
            this.check_save.Name = "check_save";
            this.check_save.Size = new System.Drawing.Size(52, 16);
            this.check_save.TabIndex = 9;
            this.check_save.Text = "Save";
            this.check_save.UseVisualStyleBackColor = true;
            // 
            // pic_origin
            // 
            this.pic_origin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_origin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_origin.Location = new System.Drawing.Point(3, 3);
            this.pic_origin.Name = "pic_origin";
            this.pic_origin.Size = new System.Drawing.Size(312, 294);
            this.pic_origin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_origin.TabIndex = 10;
            this.pic_origin.TabStop = false;
            // 
            // btn_settingsave
            // 
            this.btn_settingsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_settingsave.Location = new System.Drawing.Point(80, 510);
            this.btn_settingsave.Name = "btn_settingsave";
            this.btn_settingsave.Size = new System.Drawing.Size(96, 23);
            this.btn_settingsave.TabIndex = 12;
            this.btn_settingsave.Text = "setting save";
            this.btn_settingsave.UseVisualStyleBackColor = true;
            this.btn_settingsave.Click += new System.EventHandler(this.Btn_settingsave_Click);
            // 
            // pic_bestsol
            // 
            this.pic_bestsol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_bestsol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_bestsol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_bestsol.Location = new System.Drawing.Point(321, 3);
            this.pic_bestsol.Name = "pic_bestsol";
            this.pic_bestsol.Size = new System.Drawing.Size(313, 294);
            this.pic_bestsol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_bestsol.TabIndex = 13;
            this.pic_bestsol.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "origin image size";
            // 
            // text_originsize
            // 
            this.text_originsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_originsize.Location = new System.Drawing.Point(362, 348);
            this.text_originsize.Name = "text_originsize";
            this.text_originsize.Size = new System.Drawing.Size(275, 21);
            this.text_originsize.TabIndex = 15;
            this.text_originsize.Text = "{256, 256}";
            // 
            // btn_runsetsave
            // 
            this.btn_runsetsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_runsetsave.Location = new System.Drawing.Point(521, 605);
            this.btn_runsetsave.Name = "btn_runsetsave";
            this.btn_runsetsave.Size = new System.Drawing.Size(116, 23);
            this.btn_runsetsave.TabIndex = 16;
            this.btn_runsetsave.Text = "setting save";
            this.btn_runsetsave.UseVisualStyleBackColor = true;
            this.btn_runsetsave.Click += new System.EventHandler(this.Btn_runsetsave_Click);
            // 
            // btn_runapply
            // 
            this.btn_runapply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_runapply.Location = new System.Drawing.Point(440, 605);
            this.btn_runapply.Name = "btn_runapply";
            this.btn_runapply.Size = new System.Drawing.Size(75, 23);
            this.btn_runapply.TabIndex = 17;
            this.btn_runapply.Text = "apply";
            this.btn_runapply.UseVisualStyleBackColor = true;
            this.btn_runapply.Click += new System.EventHandler(this.Btn_runapply_Click);
            // 
            // text_cutsize
            // 
            this.text_cutsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_cutsize.Location = new System.Drawing.Point(362, 386);
            this.text_cutsize.Name = "text_cutsize";
            this.text_cutsize.Size = new System.Drawing.Size(275, 21);
            this.text_cutsize.TabIndex = 19;
            this.text_cutsize.Text = "{16, 16}";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "cut size";
            // 
            // text_crosstype
            // 
            this.text_crosstype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_crosstype.Location = new System.Drawing.Point(362, 424);
            this.text_crosstype.Name = "text_crosstype";
            this.text_crosstype.Size = new System.Drawing.Size(275, 21);
            this.text_crosstype.TabIndex = 21;
            this.text_crosstype.Text = "4";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "CrossType, 1) Vertical, 2) Horizontal, 4) Random";
            // 
            // text_grayscale
            // 
            this.text_grayscale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_grayscale.Location = new System.Drawing.Point(362, 462);
            this.text_grayscale.Name = "text_grayscale";
            this.text_grayscale.Size = new System.Drawing.Size(134, 21);
            this.text_grayscale.TabIndex = 23;
            this.text_grayscale.Text = "true";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "gray scale";
            // 
            // text_mutrange
            // 
            this.text_mutrange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_mutrange.Location = new System.Drawing.Point(362, 500);
            this.text_mutrange.Name = "text_mutrange";
            this.text_mutrange.Size = new System.Drawing.Size(134, 21);
            this.text_mutrange.TabIndex = 25;
            this.text_mutrange.Text = "false";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "mutation range random";
            // 
            // text_mutoverchange
            // 
            this.text_mutoverchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_mutoverchange.Location = new System.Drawing.Point(362, 538);
            this.text_mutoverchange.Name = "text_mutoverchange";
            this.text_mutoverchange.Size = new System.Drawing.Size(134, 21);
            this.text_mutoverchange.TabIndex = 27;
            this.text_mutoverchange.Text = "false";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "mutation over change";
            // 
            // text_elite
            // 
            this.text_elite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_elite.Location = new System.Drawing.Point(362, 578);
            this.text_elite.Name = "text_elite";
            this.text_elite.Size = new System.Drawing.Size(275, 21);
            this.text_elite.TabIndex = 29;
            this.text_elite.Text = "2";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "elite survive";
            // 
            // text_mutpercent
            // 
            this.text_mutpercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_mutpercent.Location = new System.Drawing.Point(504, 538);
            this.text_mutpercent.Name = "text_mutpercent";
            this.text_mutpercent.Size = new System.Drawing.Size(133, 21);
            this.text_mutpercent.TabIndex = 35;
            this.text_mutpercent.Text = "0.3";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(502, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "mutation percent";
            // 
            // text_mutmaxcount
            // 
            this.text_mutmaxcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_mutmaxcount.Location = new System.Drawing.Point(504, 500);
            this.text_mutmaxcount.Name = "text_mutmaxcount";
            this.text_mutmaxcount.Size = new System.Drawing.Size(133, 21);
            this.text_mutmaxcount.TabIndex = 33;
            this.text_mutmaxcount.Text = "20";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "mutation max count";
            // 
            // text_mutsize
            // 
            this.text_mutsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_mutsize.Location = new System.Drawing.Point(504, 462);
            this.text_mutsize.Name = "text_mutsize";
            this.text_mutsize.Size = new System.Drawing.Size(133, 21);
            this.text_mutsize.TabIndex = 31;
            this.text_mutsize.Text = "5";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "mutation point size";
            // 
            // check_median
            // 
            this.check_median.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_median.AutoSize = true;
            this.check_median.Location = new System.Drawing.Point(62, 377);
            this.check_median.Name = "check_median";
            this.check_median.Size = new System.Drawing.Size(93, 16);
            this.check_median.TabIndex = 36;
            this.check_median.Text = "median filter";
            this.check_median.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_apply.Location = new System.Drawing.Point(-1, 510);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 11;
            this.btn_apply.Text = "apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_run.Location = new System.Drawing.Point(182, 510);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 37;
            this.btn_run.Text = "execute";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.Location = new System.Drawing.Point(263, 510);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 38;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(2, 553);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(80, 12);
            this.label_status.TabIndex = 39;
            this.label_status.Text = "Status : none";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pic_origin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_bestsol, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 300);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.check_median);
            this.Controls.Add(this.text_mutpercent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_mutmaxcount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_mutsize);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.text_elite);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_mutoverchange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_mutrange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_grayscale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_crosstype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_cutsize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_runapply);
            this.Controls.Add(this.btn_runsetsave);
            this.Controls.Add(this.text_originsize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_settingsave);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.check_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_csv);
            this.Controls.Add(this.text_csv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_savefolder);
            this.Controls.Add(this.text_savefolder);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.text_image);
            this.Name = "Form1";
            this.Text = "Genetic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic_origin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bestsol)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_image;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.TextBox text_savefolder;
        private System.Windows.Forms.Button btn_savefolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.TextBox text_csv;
        private System.Windows.Forms.CheckBox check_save;
        private System.Windows.Forms.PictureBox pic_origin;
        private System.Windows.Forms.Button btn_settingsave;
        private System.Windows.Forms.PictureBox pic_bestsol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_originsize;
        private System.Windows.Forms.Button btn_runsetsave;
        private System.Windows.Forms.Button btn_runapply;
        private System.Windows.Forms.TextBox text_cutsize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_crosstype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_grayscale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_mutrange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_mutoverchange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_elite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_mutpercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_mutmaxcount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_mutsize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox check_median;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

