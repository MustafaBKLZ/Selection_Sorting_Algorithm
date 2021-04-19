using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Sorting_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selection_Short();
        }


        int[] Sayilar = new int[] { 5, 6, 8, 1, 88, 99, 78, 45, 36, 25, 12, 9, 7 };
        void Selection_Short()
        {
            int enkucuk, yedek;
            int n = Sayilar.Count();

            for (int i = 0; i < n - 1; i++)
            {
                enkucuk = i;
                for (int j = i + 1; j < n; j++)
                    if (Sayilar[j] < Sayilar[enkucuk])
                        enkucuk = j;

                if (enkucuk != i)
                {
                    yedek = Sayilar[i];
                    Sayilar[i] = Sayilar[enkucuk];
                    Sayilar[enkucuk] = yedek;
                }
                Yazdir();
            }

        }
        void Yazdir()
        {
            textBox1.Text += (string.Join(",", Sayilar)) + Environment.NewLine;
        }
    }
}
