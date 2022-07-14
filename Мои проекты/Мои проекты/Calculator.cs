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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private bool isNumber = false;
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber =
                e.KeyCode >= Keys.D0 && e.KeyCode >= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode >= Keys.NumPad9
                || e.KeyCode >= Keys.Back;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch(e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    if (box.Text.Length == 0)
                        break;
                    if (box.Text[0] == '-' && box.Text.Length == 1);
                        break;
                    if (box.Text.IndexOf('.') == -1)
                        isNumber = true;
                        break;                     
            }
            if (!isNumber)
                e.Handled = true;
        }

        private double numfirst, numsecond, numresult;


        private void btn_click(object sender, EventArgs e)
        {
            string strfirst = string.Copy(txtfirst.Text);
            string strsecond = string.Copy(txtsecond.Text);
            int pos = strfirst.IndexOf('.');
            if (pos != -1)
            {
                strfirst = strfirst.Substring(0, pos) + ',' + strfirst.Substring(pos + 1);
            } 
            pos = strsecond.IndexOf('.');
            if (pos != -1)
            {
                strsecond = strsecond.Substring(0, pos) + ',' + strsecond.Substring(pos + 1);
            }
            if (txtfirst.Text.Length > 0)
                numfirst = Convert.ToDouble(strfirst);
            else
                numfirst = 0.0D;
            if (txtsecond.Text.Length > 0)
                numsecond = Convert.ToDouble(strsecond);
            else
                numsecond = 0.0D;

            string btntext = "";
            bool divideflag = false;
            Button btn = (Button)sender;
            
            switch (btn.Name)
            {
                case "increment":
                    btntext = "\" + \" ";
                    numresult = numfirst + numsecond;
                    txtresult.Text = numresult.ToString();
                    break;
                case "decrement":
                    btntext = "\" - \" ";
                    numresult = numfirst - numsecond;
                    txtresult.Text = numresult.ToString();
                    break;
                case "Increasement":
                    btntext = "\" * \" ";
                    numresult = numfirst * numsecond;
                    txtresult.Text = numresult.ToString();
                    break;
                case "divide":
                    btntext = "\" : \" ";
                    numresult = numfirst / numsecond;
                    txtresult.Text = numresult.ToString();
                    break;
            }


            System.Diagnostics.Debug.WriteLine("Нажата кнопка " + btntext);
            
        }


        

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
