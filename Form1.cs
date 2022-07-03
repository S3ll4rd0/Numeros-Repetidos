using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repetidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] listaNumString = textBox1.Text.Split(',');
            int[] listaNumInt = new int[listaNumString.Length];

            int max = 0;
            for (int i = 0; i < listaNumInt.Length; i++)
            {
                listaNumInt[i] = int.Parse(listaNumString[i]);
            }
            int[] moda = new int[listaNumString.Length];
            for (int i = 0; i < listaNumString.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < listaNumString.Length; j++)
                {
                    if (listaNumInt[i] == listaNumInt[j])
                    {
                        count++;
                    }
                    if (count > max)
                    {
                        max = count;
                    }
                }
                moda[i] = count;
            }
            
            int[] orden = new int[listaNumString.Length];
            for (int i = 0; i < listaNumString.Length; i++)
            {
                if (moda[i] == max)
                {
                    MessageBox.Show(listaNumInt[i].ToString() + " -> " + moda[i]);
                }
            }
        }
    }
}
