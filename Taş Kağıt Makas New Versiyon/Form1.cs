using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas_New_Versiyon
{
    public partial class Form1 : Form
    {
        string[] oyun = {"Taş","Kağıt","Makas" };

        int x, y;
        
        Random r = new Random();

       
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                x = r.Next(0, 3);
                y = r.Next(0,3);

                button1.Text = oyun[x];
                button2.Text = oyun[y];
            }

            if ((x==0 && y==2) || (x==1 && y==0) ||(x==2 && y==1) )
            {
                label4.Text = "1. Oyuncu Kazandı";
            }

            else if (x==y)
            {
                label4.Text = "Berabere";
            }

            else
            {
                label4.Text = "2. Oyuncu Kazandı";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
