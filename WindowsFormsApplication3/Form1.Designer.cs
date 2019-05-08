namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.pixelliseButton = new System.Windows.Forms.Button();
            this.GreyScaleButton = new System.Windows.Forms.Button();
            this.LimitColoursButton = new System.Windows.Forms.Button();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZoomButton = new System.Windows.Forms.Button();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.RGBEditButton = new System.Windows.Forms.Button();
            this.InvertButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ColoursButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(518, 21);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Pixel Size :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(576, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Add a Grid?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(518, 48);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 11;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(681, 21);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset All";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // pixelliseButton
            // 
            this.pixelliseButton.Location = new System.Drawing.Point(518, 228);
            this.pixelliseButton.Name = "pixelliseButton";
            this.pixelliseButton.Size = new System.Drawing.Size(75, 23);
            this.pixelliseButton.TabIndex = 13;
            this.pixelliseButton.Text = "Pixelise";
            this.pixelliseButton.UseVisualStyleBackColor = true;
            this.pixelliseButton.Click += new System.EventHandler(this.pixelliseButton_Click);
            // 
            // GreyScaleButton
            // 
            this.GreyScaleButton.Location = new System.Drawing.Point(600, 228);
            this.GreyScaleButton.Name = "GreyScaleButton";
            this.GreyScaleButton.Size = new System.Drawing.Size(75, 23);
            this.GreyScaleButton.TabIndex = 14;
            this.GreyScaleButton.Text = "GreyScale";
            this.GreyScaleButton.UseVisualStyleBackColor = true;
            this.GreyScaleButton.Click += new System.EventHandler(this.GreyScaleButton_Click);
            // 
            // LimitColoursButton
            // 
            this.LimitColoursButton.Location = new System.Drawing.Point(681, 228);
            this.LimitColoursButton.Name = "LimitColoursButton";
            this.LimitColoursButton.Size = new System.Drawing.Size(75, 23);
            this.LimitColoursButton.TabIndex = 15;
            this.LimitColoursButton.Text = "Limit Colours";
            this.LimitColoursButton.UseVisualStyleBackColor = true;
            this.LimitColoursButton.Click += new System.EventHandler(this.LimitColoursButton_Click);
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.Location = new System.Drawing.Point(681, 48);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Size = new System.Drawing.Size(75, 23);
            this.ResetImageButton.TabIndex = 16;
            this.ResetImageButton.Text = "Reset Image";
            this.ResetImageButton.UseVisualStyleBackColor = true;
            this.ResetImageButton.Click += new System.EventHandler(this.ResetImageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Press to alter your image :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "BE CAREFUL!! Using Limit Colours on large images ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "may take a long time on slow computers";
            // 
            // ZoomButton
            // 
            this.ZoomButton.Location = new System.Drawing.Point(12, 339);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(75, 23);
            this.ZoomButton.TabIndex = 20;
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.UseVisualStyleBackColor = true;
            this.ZoomButton.Click += new System.EventHandler(this.ZoomButton_Click);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(789, 220);
            this.BlueTrackBar.Margin = new System.Windows.Forms.Padding(1);
            this.BlueTrackBar.Maximum = 100;
            this.BlueTrackBar.Minimum = 1;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(192, 45);
            this.BlueTrackBar.TabIndex = 29;
            this.BlueTrackBar.Value = 1;
            this.BlueTrackBar.ValueChanged += new System.EventHandler(this.BlueTrackBar_ValueChanged);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(789, 149);
            this.GreenTrackBar.Margin = new System.Windows.Forms.Padding(1);
            this.GreenTrackBar.Maximum = 100;
            this.GreenTrackBar.Minimum = 1;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(192, 45);
            this.GreenTrackBar.TabIndex = 28;
            this.GreenTrackBar.Value = 1;
            this.GreenTrackBar.ValueChanged += new System.EventHandler(this.GreenTrackBar_ValueChanged);
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(789, 81);
            this.RedTrackBar.Margin = new System.Windows.Forms.Padding(1);
            this.RedTrackBar.Maximum = 100;
            this.RedTrackBar.Minimum = 1;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(192, 45);
            this.RedTrackBar.TabIndex = 27;
            this.RedTrackBar.Value = 1;
            this.RedTrackBar.ValueChanged += new System.EventHandler(this.RedTrackBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Red Value :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Green Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(789, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Blue Value :";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(847, 289);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 33;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RGBEditButton
            // 
            this.RGBEditButton.Location = new System.Drawing.Point(518, 313);
            this.RGBEditButton.Name = "RGBEditButton";
            this.RGBEditButton.Size = new System.Drawing.Size(75, 23);
            this.RGBEditButton.TabIndex = 34;
            this.RGBEditButton.Text = "RGB Edit";
            this.RGBEditButton.UseVisualStyleBackColor = true;
            this.RGBEditButton.Click += new System.EventHandler(this.RGBEditButton_Click);
            // 
            // InvertButton
            // 
            this.InvertButton.Location = new System.Drawing.Point(600, 313);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(75, 23);
            this.InvertButton.TabIndex = 35;
            this.InvertButton.Text = "Invert";
            this.InvertButton.UseVisualStyleBackColor = true;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Sepia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SepiaButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(93, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(148, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(203, 320);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(258, 320);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(313, 320);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 50);
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 42;
            this.button1.Text = "Most Common Colours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColoursButton
            // 
            this.ColoursButton.Location = new System.Drawing.Point(646, 342);
            this.ColoursButton.Name = "ColoursButton";
            this.ColoursButton.Size = new System.Drawing.Size(110, 31);
            this.ColoursButton.TabIndex = 43;
            this.ColoursButton.Text = "How Many Colours";
            this.ColoursButton.UseVisualStyleBackColor = true;
            this.ColoursButton.Click += new System.EventHandler(this.ColoursButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 382);
            this.Controls.Add(this.ColoursButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InvertButton);
            this.Controls.Add(this.RGBEditButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BlueTrackBar);
            this.Controls.Add(this.GreenTrackBar);
            this.Controls.Add(this.RedTrackBar);
            this.Controls.Add(this.ZoomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetImageButton);
            this.Controls.Add(this.LimitColoursButton);
            this.Controls.Add(this.GreyScaleButton);
            this.Controls.Add(this.pixelliseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Cammy Something or Other";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button pixelliseButton;
        private System.Windows.Forms.Button GreyScaleButton;
        private System.Windows.Forms.Button LimitColoursButton;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZoomButton;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.TrackBar RedTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RGBEditButton;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ColoursButton;
    }
}

        #endregion