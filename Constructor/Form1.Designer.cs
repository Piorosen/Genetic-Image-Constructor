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
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.picGenetic = new System.Windows.Forms.PictureBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.labelGenCount = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.textLoadPath = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCrossCount = new System.Windows.Forms.TextBox();
            this.textSurvive = new System.Windows.Forms.TextBox();
            this.textMutation = new System.Windows.Forms.TextBox();
            this.textCount = new System.Windows.Forms.TextBox();
            this.optionGrayScale = new System.Windows.Forms.CheckBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.optionMedianFilter = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenetic)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOrigin
            // 
            this.picOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrigin.Location = new System.Drawing.Point(12, 25);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(256, 256);
            this.picOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrigin.TabIndex = 0;
            this.picOrigin.TabStop = false;
            // 
            // picGenetic
            // 
            this.picGenetic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGenetic.Location = new System.Drawing.Point(360, 25);
            this.picGenetic.Name = "picGenetic";
            this.picGenetic.Size = new System.Drawing.Size(256, 256);
            this.picGenetic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGenetic.TabIndex = 1;
            this.picGenetic.TabStop = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(360, 312);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // labelGenCount
            // 
            this.labelGenCount.AutoSize = true;
            this.labelGenCount.Location = new System.Drawing.Point(358, 297);
            this.labelGenCount.Name = "labelGenCount";
            this.labelGenCount.Size = new System.Drawing.Size(38, 12);
            this.labelGenCount.TabIndex = 3;
            this.labelGenCount.Text = "0 Gen";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(193, 341);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // textLoadPath
            // 
            this.textLoadPath.Location = new System.Drawing.Point(12, 294);
            this.textLoadPath.Multiline = true;
            this.textLoadPath.Name = "textLoadPath";
            this.textLoadPath.Size = new System.Drawing.Size(256, 41);
            this.textLoadPath.TabIndex = 5;
            this.textLoadPath.Text = "C:\\Users\\aoika\\Desktop\\MyImage.png";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textCrossCount);
            this.groupBox.Controls.Add(this.textSurvive);
            this.groupBox.Controls.Add(this.textMutation);
            this.groupBox.Controls.Add(this.textCount);
            this.groupBox.Controls.Add(this.optionGrayScale);
            this.groupBox.Location = new System.Drawing.Point(360, 341);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(310, 207);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Option";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "CrossCount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Survive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mutation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Count";
            // 
            // textCrossCount
            // 
            this.textCrossCount.Location = new System.Drawing.Point(100, 123);
            this.textCrossCount.Name = "textCrossCount";
            this.textCrossCount.Size = new System.Drawing.Size(191, 21);
            this.textCrossCount.TabIndex = 12;
            this.textCrossCount.Text = "3";
            // 
            // textSurvive
            // 
            this.textSurvive.Location = new System.Drawing.Point(100, 96);
            this.textSurvive.Name = "textSurvive";
            this.textSurvive.Size = new System.Drawing.Size(191, 21);
            this.textSurvive.TabIndex = 11;
            this.textSurvive.Text = "10";
            // 
            // textMutation
            // 
            this.textMutation.Location = new System.Drawing.Point(100, 69);
            this.textMutation.Name = "textMutation";
            this.textMutation.Size = new System.Drawing.Size(191, 21);
            this.textMutation.TabIndex = 10;
            this.textMutation.Text = "0.01";
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(100, 42);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(191, 21);
            this.textCount.TabIndex = 9;
            this.textCount.Text = "50";
            // 
            // optionGrayScale
            // 
            this.optionGrayScale.AutoSize = true;
            this.optionGrayScale.Checked = true;
            this.optionGrayScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionGrayScale.Location = new System.Drawing.Point(6, 20);
            this.optionGrayScale.Name = "optionGrayScale";
            this.optionGrayScale.Size = new System.Drawing.Size(99, 16);
            this.optionGrayScale.TabIndex = 8;
            this.optionGrayScale.Text = "Change Gray";
            this.optionGrayScale.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 379);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(256, 21);
            this.textName.TabIndex = 7;
            this.textName.Text = "Test1";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(12, 411);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(256, 41);
            this.textResult.TabIndex = 8;
            this.textResult.Text = "C:\\Users\\aoika\\Desktop\\result.csv";
            // 
            // optionMedianFilter
            // 
            this.optionMedianFilter.AutoSize = true;
            this.optionMedianFilter.Location = new System.Drawing.Point(46, 466);
            this.optionMedianFilter.Name = "optionMedianFilter";
            this.optionMedianFilter.Size = new System.Drawing.Size(114, 16);
            this.optionMedianFilter.TabIndex = 9;
            this.optionMedianFilter.Text = "Median Filtering";
            this.optionMedianFilter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optionMedianFilter);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textLoadPath);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labelGenCount);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.picGenetic);
            this.Controls.Add(this.picOrigin);
            this.Name = "Form1";
            this.Text = "Genetic";
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenetic)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.PictureBox picGenetic;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label labelGenCount;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox textLoadPath;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.CheckBox optionGrayScale;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.TextBox textCrossCount;
        private System.Windows.Forms.TextBox textSurvive;
        private System.Windows.Forms.TextBox textMutation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.CheckBox optionMedianFilter;
        private System.Windows.Forms.Button button1;
    }
}

