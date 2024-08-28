
namespace LR3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(31, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(183, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить в корзину";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес(г)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена(руб)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Доставка(руб)";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(113, 104);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(135, 23);
            this.HeightBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(113, 142);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(135, 23);
            this.PriceBox.TabIndex = 8;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ResultBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.ResultBox.Location = new System.Drawing.Point(633, 57);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(393, 256);
            this.ResultBox.TabIndex = 10;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox.Controls.Add(this.comboBox2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.PriceBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.HeightBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(31, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(292, 278);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Информация";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Iphone 12",
            "Samsung Galaxy S20",
            "Redmi Note 11",
            "POCO X3 Pro",
            "Asus ROG 3",
            "Huawei MateBook",
            "MacBook",
            "Lenovo IdeaPad",
            "Honor MagicBook",
            "Acer Aspire"});
            this.comboBox2.Location = new System.Drawing.Point(113, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 23);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(633, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Открыть корзину";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(843, 347);
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(183, 23);
            this.sumBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(891, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Общая стоимость(руб)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(805, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Просмотр";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(843, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Сделать заказ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 432);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Товары";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox sumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}

