namespace DrawHere
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файйлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvasesCombo = new System.Windows.Forms.ComboBox();
            this.widthTrack = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drawBtn = new System.Windows.Forms.Button();
            this.eraserBtn = new System.Windows.Forms.Button();
            this.colorSelectBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.forthBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.inCirclesChk = new System.Windows.Forms.CheckBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.framesBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrack)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.framesBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файйлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файйлToolStripMenuItem
            // 
            this.файйлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файйлToolStripMenuItem.Name = "файйлToolStripMenuItem";
            this.файйлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файйлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.создатьToolStripMenuItem.Text = "Создать...";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.canvasesCombo);
            this.panel1.Controls.Add(this.widthTrack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 63);
            this.panel1.TabIndex = 1;
            // 
            // canvasesCombo
            // 
            this.canvasesCombo.FormattingEnabled = true;
            this.canvasesCombo.Location = new System.Drawing.Point(860, 17);
            this.canvasesCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvasesCombo.Name = "canvasesCombo";
            this.canvasesCombo.Size = new System.Drawing.Size(189, 24);
            this.canvasesCombo.TabIndex = 1;
            // 
            // widthTrack
            // 
            this.widthTrack.Location = new System.Drawing.Point(16, 4);
            this.widthTrack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthTrack.Maximum = 100;
            this.widthTrack.Minimum = 1;
            this.widthTrack.Name = "widthTrack";
            this.widthTrack.Size = new System.Drawing.Size(139, 56);
            this.widthTrack.TabIndex = 0;
            this.widthTrack.Value = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.drawBtn);
            this.panel2.Controls.Add(this.eraserBtn);
            this.panel2.Controls.Add(this.colorSelectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 461);
            this.panel2.TabIndex = 2;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(16, 43);
            this.drawBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(31, 28);
            this.drawBtn.TabIndex = 2;
            this.drawBtn.Text = "К";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.Location = new System.Drawing.Point(16, 79);
            this.eraserBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(31, 28);
            this.eraserBtn.TabIndex = 1;
            this.eraserBtn.Text = "Л";
            this.eraserBtn.UseVisualStyleBackColor = true;
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            // 
            // colorSelectBtn
            // 
            this.colorSelectBtn.BackColor = System.Drawing.Color.Black;
            this.colorSelectBtn.Location = new System.Drawing.Point(16, 7);
            this.colorSelectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorSelectBtn.Name = "colorSelectBtn";
            this.colorSelectBtn.Size = new System.Drawing.Size(31, 28);
            this.colorSelectBtn.TabIndex = 0;
            this.colorSelectBtn.UseVisualStyleBackColor = false;
            this.colorSelectBtn.Click += new System.EventHandler(this.colorSelectBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(97, 93);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 461);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.forthBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.inCirclesChk);
            this.panel4.Controls.Add(this.stopBtn);
            this.panel4.Controls.Add(this.startBtn);
            this.panel4.Controls.Add(this.framesBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 344);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(970, 117);
            this.panel4.TabIndex = 1;
            // 
            // forthBtn
            // 
            this.forthBtn.Location = new System.Drawing.Point(935, 74);
            this.forthBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forthBtn.Name = "forthBtn";
            this.forthBtn.Size = new System.Drawing.Size(31, 28);
            this.forthBtn.TabIndex = 5;
            this.forthBtn.Text = ">";
            this.forthBtn.UseVisualStyleBackColor = true;
            this.forthBtn.Click += new System.EventHandler(this.forthBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1, 69);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(31, 28);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // inCirclesChk
            // 
            this.inCirclesChk.AutoSize = true;
            this.inCirclesChk.BackColor = System.Drawing.Color.Gray;
            this.inCirclesChk.Location = new System.Drawing.Point(227, 21);
            this.inCirclesChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inCirclesChk.Name = "inCirclesChk";
            this.inCirclesChk.Size = new System.Drawing.Size(93, 20);
            this.inCirclesChk.TabIndex = 3;
            this.inCirclesChk.Text = "Циклично";
            this.inCirclesChk.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(117, 15);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(100, 28);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Стоп";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(9, 15);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 28);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // framesBar
            // 
            this.framesBar.Location = new System.Drawing.Point(29, 62);
            this.framesBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.framesBar.Maximum = 24;
            this.framesBar.Name = "framesBar";
            this.framesBar.Size = new System.Drawing.Size(911, 56);
            this.framesBar.TabIndex = 0;
            this.framesBar.Scroll += new System.EventHandler(this.framesBar_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DrawHere";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.framesBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файйлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button colorSelectBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar widthTrack;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button eraserBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar framesBar;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckBox inCirclesChk;
        private System.Windows.Forms.Button forthBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox canvasesCombo;
    }
}

