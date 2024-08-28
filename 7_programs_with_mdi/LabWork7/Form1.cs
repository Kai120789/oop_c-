using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork7
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        



        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                FormChild fc = new FormChild();
                fc.MdiParent = this;
                fc.Size = new Size(800 / Convert.ToInt32(textBox2.Text), 422);
                fc.Show();
            }
            else
            {
                FormChild fc = new FormChild();
                fc.MdiParent = this;
                fc.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontaleTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        
        private void verticaleTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private RichTextBox GetRichTextBox()
        {
            Form activeChild = this.ActiveMdiChild;
            RichTextBox none = null;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBrox = (RichTextBox)activeChild.ActiveControl;
                    if (theBrox != null)
                    {
                        return theBrox;
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
            return none;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            int N = Convert.ToInt32(textBox1.Text);

            int M = Convert.ToInt32(textBox2.Text);

            Random rnd = new Random();

            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rnd.Next(100);
                    Console.Write(matrix[i, j] + " ");
                }

            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = true;
            
            int columns = 1;
            while (columns != 100)
            {
                dataGridView1.Columns.Add(columns.ToString(), columns.ToString());
                columns++;
            }
            dataGridView1.Rows.Add(100);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    dataGridView1[i, j].Value = matrix[i, j];
                    //dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            dataGridView1.Refresh();
            Thread.Sleep(1500);
            dataGridView1.Visible = false;
            dataGridView1.Refresh();
            Thread.Sleep(1500);
            int loc = 0;
            for (int i = 0; i < N; i++)
            {
                FormChild fc = new FormChild();
                fc.MdiParent = this;
                fc.Text = Convert.ToString(i+1);
                fc.Size = new Size(170, 422);
                fc.Show();
                //fc.Visible = false;
                fc.Location = new Point(loc, 0);
                loc += 170;
                fc.dataGridView2.Columns.Add(1.ToString(), "Столбец №" + (i +1).ToString());
                fc.dataGridView2.Rows.Add(100);
                for (int j = 0; j < M; j++)
                {
                    fc.dataGridView2[0, j].Value = matrix[i, j];
                    //dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            

        }
    }
}
