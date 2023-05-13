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
            Azione1();
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
            reader.Close();
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
                    asd = 0;
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
            reader.Close();
            return lunghezzaMax;
        }

        private void Azione4()
        {
            string s;
            int i = 0;
            StreamReader reader = new StreamReader(fileName1);
            StreamWriter writer = new StreamWriter("temporaneo.csv");

            s = reader.ReadLine();
            while (s != null)
            {
                if (i != 0)
                {
                    writer.WriteLine(s.PadRight(70) + "#");
                }
                else
                {
                    writer.WriteLine(s);
                }

                s = reader.ReadLine();
                i++;
            }

            

            reader.Close();
            writer.Close();

            File.Replace("temporaneo.csv", fileName1, "backup.csv");
        }
        
        private void Azione6()
        {
            string s;
            int i = 0;
            StreamReader reader = new StreamReader("mariani1.csv");

            s = reader.ReadLine();

            while (s != null)
            {
                String[] split = s.Split(';');

                listView2.Items.Add($"{split[0]};{split[1]};{split[4]}");

                i++;
                s = reader.ReadLine();
            }

            reader.Close();
        }

        private void azione1_Click(object sender, EventArgs e)
        {
            Azione1();
        }

        private void azione2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In un Record ci sono " + Azione2() + " Campi");
        }

        private void azione3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            listView1.Clear();
            int[] ints = new int[Azione2()];
            int temp;
            ints = Azione3Avanzato();

            StreamWriter writer = new StreamWriter("temp.txt", append: false);
            writer.WriteLine("In un Record ci sono massimo " + Azione3() + " caratteri\n");
            for (int i = 0; i < Azione2(); i++)
            {
                temp = i + 1;
                writer.WriteLine("Nel " + temp + " campo ci sono massimo " + ints[i] + " caratteri");
            }
            writer.Close();
            StreamReader reader = new StreamReader("temp.txt");
            string s = "";
            while ((s = reader.ReadLine()) != null)
            {
                listView1.Items.Add(s);
            }
            reader.Close();
        }

        private void azione4_Click(object sender, EventArgs e)
        {
            Azione4();
        }

        private void azione5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void azione6_Click(object sender, EventArgs e)
        {
            Azione6();
            groupBox2.Show();
        }

        private void closeGroupBox1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            groupBox1.Hide();
        }

        private void closeGroupBox2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            groupBox2.Hide();
        }
    }
}