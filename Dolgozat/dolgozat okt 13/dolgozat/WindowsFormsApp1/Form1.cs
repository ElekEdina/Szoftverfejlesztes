using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 

    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
       
              
        private void AdatokFeltolt1(int sor, int oszlop)
        {
            matrix1.Columns.Clear();
            matrix1.Rows.Clear();
           

            
            for (int i = 0; i < oszlop; i++)
            {
                matrix1.Columns.Add(String.Empty, String.Empty);
                matrix1.Columns[i].Width = 35;
                
            }

            
            for (int i = 0; i < sor; i++)
            {
                object[] intTomb = new object[oszlop]; 
                for (int j = 0; j < oszlop; j++)
                {
                    intTomb[j] = random.Next(-10, 10); 
                }
                matrix1.Rows.Add(intTomb);
                
            }
        }

        private void AdatokFeltolt2(int sor, int oszlop)
        {
           
            matrix2.Columns.Clear();
            matrix2.Rows.Clear();


            for (int i = 0; i < oszlop; i++)
            {
                
                matrix2.Columns.Add(String.Empty, String.Empty);
                matrix2.Columns[i].Width = 35;
            }


            for (int i = 0; i < sor; i++)
            {
                object[] intTomb = new object[oszlop];
                for (int j = 0; j < oszlop; j++)
                {
                    intTomb[j] = random.Next(-10, 10);
                }
                
                matrix2.Rows.Add(intTomb);
            }
        }

        private int skalaris()
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    skalarOsszeg += Convert.ToInt32(matrix1[i, j].Value) * Convert.ToInt32(matrix2[i, j].Value);
                }
            }
            return skalarOsszeg;
        }

        private int skalarisvissza() 
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);
            int matrix2sor = sor;
            int matrix2oszlop = sor;

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    skalarOsszeg += Convert.ToInt32(matrix1[i, j].Value) * Convert.ToInt32(matrix2[matrix2sor, matrix2oszlop].Value);
                    
                    matrix2sor--;
                }
                matrix2sor = sor;
                matrix2oszlop--;
            }
            return skalarOsszeg;
        }

        private int skalarAtlo() 
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);
            int matrix1AtloOsszeg = 0;
            int matrix2AtloOsszeg = 0;

            for (int i = 0; i < sor; i++)
            {
                matrix1AtloOsszeg += 
                   Convert.ToInt32(matrix1[i,i].Value);
            }

            for (int i = 0; i < sor; i++)
            {
                matrix2AtloOsszeg += Convert.ToInt32(matrix1[i, i].Value);
            }

            skalarOsszeg = matrix1AtloOsszeg - matrix2AtloOsszeg;
            return skalarOsszeg;
        }

       

        private int skalarAtloFelett() 
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);


            for (int i = 1; i < sor; i++)
            {
                skalarOsszeg += Convert.ToInt32(matrix1[i - 1, i].Value); 
            }
            return skalarOsszeg;
        }

        private void EredmenyKiir()
        {
            richTextBox1.ResetText();
            if (skalaris() > 0) { richTextBox1.ForeColor = Color.Blue; }
            else { richTextBox1.
                    ForeColor = Color.Red; }
            richTextBox1.AppendText(String.Format("Eredmény{0}\n", skalaris())); 



            if (skalaris() > 0) { richTextBox1.ForeColor = Color.Blue; }
            else
            {
                richTextBox1.
                 ForeColor = Color.Red;
            }
            /*richTextBox1.AppendText(String.Format("Eredmény{0}\n", skalarisvissza()));

            if (skalaris() > 0) { richTextBox1.ForeColor = Color.Blue; }
            else
            {
                richTextBox1.
                 ForeColor = Color.Red;
            }
            richTextBox1.AppendText(String.Format("Eredmény{0}\n", skalarAtlo()));*/

            if (skalaris() > 0) { richTextBox1.ForeColor = Color.Blue; }
            else
            {
                richTextBox1.
                 ForeColor = Color.Red;
            }
            richTextBox1.AppendText(String.Format("Eredmény{0}\n", skalarAtloFelett()));


        }



        private void btnGen_Click(object sender, EventArgs e)
        {

            AdatokFeltolt1(Convert.ToInt32(nud1.Value), Convert.ToInt32(nud1.Value));
            AdatokFeltolt2(Convert.ToInt32(nud1.Value), Convert.ToInt32(nud1.Value));
            EredmenyKiir();
        }
    }

   
        }
    
