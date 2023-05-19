using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mariani_ElaborazioneCSV
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int Ricerca(string parola)
        {
            StreamReader reader = new StreamReader("mariani1.csv");
            string s;
            int i = 0;
            s = reader.ReadLine();
            while (s != null)
            {

                String[] split = s.Split(';');
                String[] split1 = split[Lunghezza() - 1].Split(' ');

                if (split1[0] == parola)
                {
                    reader.Close();
                    return i;
                }

                i++;
                s = reader.ReadLine();

            }
            reader.Close();
            return -1;
        }

        private int Lunghezza()
        {
            string s;
            int count = 0;
            StreamReader reader = new StreamReader("mariani1.csv");
            s = reader.ReadLine();
            reader.Close();
            return count = s.Split(';').Length;

        }

        private void Azione8(string anno, string regione, float t_femm, float t_masc, float t_both, int val_rand, bool logico, int linea)
        {
            StreamReader reader = new StreamReader("mariani1.csv");
            StreamWriter writer = new StreamWriter("appoggio.csv");

            string s;
            int i = 0;
            s = reader.ReadLine();
            
            while (s != null)
            {
                if (i != 0)
                {
                    string[] split = s.Split(';');
                    string[] split1 = split[Lunghezza() - 1].Split(' ');
                    int rigaAttuale = int.Parse(split1[0]);

                    if (rigaAttuale == linea)
                    {
                        s = $"{anno};{regione};{t_femm};{t_masc};{t_both};{val_rand};{logico};{linea}".PadRight(70);
                        writer.WriteLine(s);
                    }
                    else
                    {
                        writer.WriteLine(s);
                    }
                }
                else
                {
                    writer.WriteLine(s);
                }

                i++;
                s = reader.ReadLine();
            }

            writer.Close();
            reader.Close();

            File.Replace("appoggio.csv", "mariani1.csv", "backup.csv");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anno = textBox1.Text;
            string regione = textBox2.Text;
            float t_femm = float.Parse(textBox3.Text);
            float t_masc = float.Parse(textBox4.Text);
            float t_both = float.Parse(textBox5.Text);
            int val_rand = int.Parse(textBox6.Text);
            bool logico = bool.Parse(textBox7.Text);
            
            int riga = Ricerca(textBox8.Text);
            Azione8(anno, regione, t_femm, t_masc, t_both, val_rand, logico, riga);
        }
    }
}
