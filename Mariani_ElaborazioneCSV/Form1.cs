using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mariani_ElaborazioneCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string fileName1 = @"mariani1.csv";
        public string fileName2 = @"mariani.csv";
        public Random r = new Random();

        private void Azione1() 
        {
            string s;
            int i = 0;
            StreamWriter writer = new StreamWriter(fileName1, append: false);
            StreamReader reader = new StreamReader(fileName2);
            s = reader.ReadLine();
            while (s != null)
            {
                if (i == 0)
                {
                    writer.WriteLine(s + ";Valore Randomico;Campo Cancellazione Logica");
                }
                else
                {
                    int valore = r.Next(10, 21);
                    writer.WriteLine(s + ";" + valore + ";false");
                }
                i++;
                s = reader.ReadLine();
            }
            writer.Close();
            reader.Close();
        }

        private int Azione2() 
        {
            string s;
            int count = 0;
            StreamReader reader = new StreamReader(fileName1);
            s = reader.ReadLine();
            reader.Close();
            return count = s.Split(';').Length;
            
        }

        private int Azione3()
        {
            StreamReader reader = new StreamReader(fileName1);
            int lunghezzaStringa = 0, lunghezzaMax = 0, i = 0;
            string s;

            s = reader.ReadLine();
            while (s != null)
            {
                lunghezzaStringa = s.Length;
                if (i != 0)
                {
                    if (lunghezzaMax < lunghezzaStringa)
                    {
                        lunghezzaMax = s.Length;
                    }
                }
                s = reader.ReadLine();
                i++;
            }
            return lunghezzaMax;
        }

        private int[] Azione3Avanzato()
        {
            StreamReader reader = new StreamReader(fileName1);
            string s = reader.ReadLine();
            int[] lunghezzaMax = new int[Azione2()];
            int asd = 0;
            s = reader.ReadLine();

            while (s != null)
            {
                string[] split = s.Split(';');
                string[] array = new string[Azione2()];
                
                for (int i = 0; i < Azione2(); i++)
                {
                    reader.DiscardBufferedData();
                    reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                    s = reader.ReadLine();
                    
                    while (s != null)
                    {
                        string[] stringaSplit = s.Split(';');
                        if (asd != 0)
                        {
                            if (lunghezzaMax[i] < stringaSplit[i].Length)
                            {
                                lunghezzaMax[i] = stringaSplit[i].Length;
                            }

                        }
                        s = reader.ReadLine();
                        asd++;
                    }
                }
            }

            return lunghezzaMax;
        }

        private void azione1_Click(object sender, EventArgs e)
        {
            Azione1();
        }

        private void azione2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In un Record ci sono " + Azione2() + " Campi");
            Azione3Avanzato();
        }

        private void azione3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il numero massimo di Caratteri in un record è " + Azione3().ToString());
        }
    }
}