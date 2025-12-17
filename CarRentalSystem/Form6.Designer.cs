namespace CarRentalSystem
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 95);
            panel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 21);
            label3.Name = "label3";
            label3.Size = new Size(460, 50);
            label3.TabIndex = 1;
            label3.Text = "Avtomobil icarəsi sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(56, 482);
            button2.Name = "button2";
            button2.Size = new Size(612, 52);
            button2.TabIndex = 32;
            button2.Text = "Əsas səhifəyə qayıt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 320);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 31;
            label2.Text = "Gün:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 160);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 30;
            label1.Text = "Maşınlar:";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 391);
            button1.Name = "button1";
            button1.Size = new Size(612, 52);
            button1.TabIndex = 29;
            button1.Text = "Əlavə et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(436, 28);
            comboBox1.TabIndex = 37;
            comboBox1.Text = "--Bir maşın seçin--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 241);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 38;
            label4.Text = "Müştərilər:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(180, 240);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(436, 28);
            comboBox2.TabIndex = 39;
            comboBox2.Text = "--Bir müştəri seçin--";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(180, 320);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(436, 27);
            maskedTextBox1.TabIndex = 40;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(730, 566);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form6";
            Text = "Avtomobili icarəyə götür";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
    }
}