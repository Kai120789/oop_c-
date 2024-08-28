
using System;

namespace ЛР2
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ProfessionBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Имя = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(96, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(219, 23);
            this.NameBox.TabIndex = 0;
            // 
            // ProfessionBox
            // 
            this.ProfessionBox.Location = new System.Drawing.Point(96, 230);
            this.ProfessionBox.Name = "ProfessionBox";
            this.ProfessionBox.Size = new System.Drawing.Size(219, 23);
            this.ProfessionBox.TabIndex = 2;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ResultBox.Location = new System.Drawing.Point(362, 12);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(385, 293);
            this.ResultBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.Имя);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.ProfessionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Menu;
            this.monthCalendar1.Location = new System.Drawing.Point(96, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Location = new System.Drawing.Point(31, 25);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(59, 15);
            this.Имя.TabIndex = 6;
            this.Имя.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата завоза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена за кг";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartButton.Location = new System.Drawing.Point(12, 285);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(330, 38);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Добавить";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 331);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Склад";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ProfessionBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

