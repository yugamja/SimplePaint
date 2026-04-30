namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            trbLineWidth = new GroupBox();
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            trbLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.MintCream;
            lblAppName.Location = new Point(25, 23);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(345, 60);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.SpringGreen;
            btnOpenFile.Font = new Font("휴먼모음T", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.ForeColor = SystemColors.ButtonHighlight;
            btnOpenFile.Location = new Point(860, 131);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(110, 63);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.Aqua;
            btnSaveFile.Font = new Font("휴먼모음T", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.ForeColor = SystemColors.ButtonHighlight;
            btnSaveFile.Location = new Point(990, 131);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(107, 63);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.ForeColor = Color.OrangeRed;
            groupBox1.Location = new Point(25, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 107);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.ForeColor = Color.DarkRed;
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(195, 30);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(85, 61);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.ForeColor = Color.DarkRed;
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(98, 30);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(91, 61);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.ForeColor = Color.DarkRed;
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(15, 30);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(73, 61);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.ForeColor = Color.OrangeRed;
            groupBox2.Location = new Point(349, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(203, 107);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "선 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(17, 45);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(165, 33);
            cmbColor.TabIndex = 0;
            // 
            // trbLineWidth
            // 
            trbLineWidth.Controls.Add(trackBar1);
            trbLineWidth.ForeColor = Color.OrangeRed;
            trbLineWidth.Location = new Point(580, 85);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(247, 107);
            trbLineWidth.TabIndex = 4;
            trbLineWidth.TabStop = false;
            trbLineWidth.Text = "선 두께";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(9, 42);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(222, 69);
            trackBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(25, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1094, 544);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1144, 779);
            Controls.Add(pictureBox1);
            Controls.Add(trbLineWidth);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            trbLineWidth.ResumeLayout(false);
            trbLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private GroupBox groupBox1;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private GroupBox groupBox2;
        private GroupBox trbLineWidth;
        private ComboBox cmbColor;
        private TrackBar trackBar1;
        private PictureBox pictureBox1;
    }
}
