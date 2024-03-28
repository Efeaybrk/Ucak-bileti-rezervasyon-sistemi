namespace Uçak_Bileti_Rezervasyon_Sistemi
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            listBox1 = new ListBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 194);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(363, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(291, 65);
            button2.Name = "button2";
            button2.Size = new Size(55, 35);
            button2.TabIndex = 11;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 113);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 142);
            maskedTextBox1.Margin = new Padding(2, 3, 2, 3);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(164, 23);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 5;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 119);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox2.Location = new Point(122, 83);
            comboBox2.Margin = new Padding(2, 3, 2, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 24);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox1.Location = new Point(122, 53);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 24);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(643, 194);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(358, 275);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.Location = new Point(168, 142);
            button1.Name = "button1";
            button1.Size = new Size(132, 37);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 94);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 9;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 71);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 8;
            label6.Text = "TC:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(157, 94);
            maskedTextBox3.Margin = new Padding(2, 3, 2, 3);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(164, 23);
            maskedTextBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(157, 65);
            maskedTextBox2.Margin = new Padding(2, 3, 2, 3);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(164, 23);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 42);
            label5.Name = "label5";
            label5.Size = new Size(128, 17);
            label5.TabIndex = 0;
            label5.Text = "Yolcu Ad Soyad:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(28, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 127);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(36, 37);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(386, 48);
            label8.TabIndex = 6;
            label8.Text = "Süpernova Hava Yolları";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(28, 493);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(973, 84);
            listBox1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 473);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 12;
            label9.Text = "geçiş";
            label9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 595);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label5;
        private Panel panel1;
        private ListBox listBox1;
        private Label label8;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
    }
}
