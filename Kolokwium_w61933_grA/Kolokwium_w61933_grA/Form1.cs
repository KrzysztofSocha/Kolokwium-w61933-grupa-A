using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium_w61933_grA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bChangeColor_Click(object sender, EventArgs e)
        {
            if(cbColor.SelectedIndex >-1 && cbNumber.SelectedIndex > -1)
            {
                if (cbColor.SelectedIndex == 0)
                {
                    int panel = cbNumber.SelectedIndex;
                    if(panel == 0)
                    {
                        panel1.BackColor = Color.Green;
                    }
                    else if (panel == 1)
                    {
                        panel2.BackColor = Color.Green;
                    }
                    else if (panel == 2)
                    {
                        panel3.BackColor = Color.Green;
                    }else if (panel == 3)
                    {
                        panel4.BackColor = Color.Green;
                    }else if (panel == 4)
                    {
                        panel5.BackColor = Color.Green;
                    }else if (panel == 5)
                    {
                        panel6.BackColor = Color.Green;
                    }else if (panel == 6)
                    {
                        panel7.BackColor = Color.Green;
                    }else if (panel == 7)
                    {
                        panel8.BackColor = Color.Green;
                    }else if (panel == 8)
                    {
                        panel9.BackColor = Color.Green;
                    }
                    
                }
                else if (cbColor.SelectedIndex == 1)
                {
                    int panel = cbNumber.SelectedIndex;
                    if (panel == 0)
                    {
                        panel1.BackColor = Color.Red;
                    }
                    else if (panel == 1)
                    {
                        panel2.BackColor = Color.Red;
                    }
                    else if (panel == 2)
                    {
                        panel3.BackColor = Color.Red;
                    }
                    else if (panel == 3)
                    {
                        panel4.BackColor = Color.Red;
                    }
                    else if (panel == 4)
                    {
                        panel5.BackColor = Color.Red;
                    }
                    else if (panel == 5)
                    {
                        panel6.BackColor = Color.Red;
                    }
                    else if (panel == 6)
                    {
                        panel7.BackColor = Color.Red;
                    }
                    else if (panel == 7)
                    {
                        panel8.BackColor = Color.Red;
                    }
                    else if (panel == 8)
                    {
                        panel9.BackColor = Color.Red;
                    }

                    
                }
                
            }
            else if (cbColor.SelectedIndex > -1 && cbNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz numer panela");
            }
            else if (cbColor.SelectedIndex == -1 && cbNumber.SelectedIndex > -1)
            {
                MessageBox.Show("Wybierz kolor");
            }
            else
            {
                MessageBox.Show("Wybierz kolor do zmiany oraz numer panela");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koniec pracy aplikacji");
            Application.Exit();
        }
    }
}
