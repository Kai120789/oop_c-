
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(35, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посмотреть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(183, 395);
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
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена за кг(руб)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "-";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(107, 276);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(135, 23);
            this.PriceBox.TabIndex = 8;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ResultBox.Location = new System.Drawing.Point(377, 57);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(393, 313);
            this.ResultBox.TabIndex = 10;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.monthCalendar1);
            this.groupBox.Controls.Add(this.comboBox2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.PriceBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.comboBox1);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(31, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(292, 358);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата завоза";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(107, 86);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Яблоки",
            "Персики",
            "Груши",
            "Бананы",
            "Сливы",
            "Помидоры",
            "Огурцы",
            "Картофель",
            "Капуста",
            "Морковь"});
            this.comboBox2.Location = new System.Drawing.Point(107, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 23);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фрукты",
            "Овощи"});
            this.comboBox1.Location = new System.Drawing.Point(68, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(377, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Открыть корзину";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(635, 406);
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(135, 23);
            this.sumBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Общая стоимость(руб)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Просмотр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox sumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
    }
}

