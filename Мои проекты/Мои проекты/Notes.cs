using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мои_проекты
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            String info;
            info = textBox2.Text;
            listBox2.Items.Add(info);
        }

        private void BtnClrLst_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



            else
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }


        }

        private void BtnClrAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
