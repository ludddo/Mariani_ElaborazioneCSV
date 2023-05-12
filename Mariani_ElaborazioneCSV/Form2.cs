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
    public partial class Form2 : Form
    {
        Random random = new Random();

        public Form2()
        {
            InitializeComponent();
        }

        private void Azione5(string anno, string regione, float t_femm, float t_masc, float t_both, int val_rand, bool logico)
        {
            string s;
            int i = 0;
            StreamReader reader = new StreamReader("mariani1.csv");
            StreamWriter writer = new StreamWriter("temporaneo.csv");

            s = reader.ReadLine();
            while (s != null)
            {
                writer.WriteLine(s);
                s = reader.ReadLine();
            }
            writer.WriteLine($"{anno};{regione};{t_femm};{t_masc};{t_both};{val_rand};{logico}".PadRight(70)+"#");

            writer.Close();
            reader.Close();

            File.Replace("temporaneo.csv", "mariani1.csv", "backup.csv");
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
            Azione5(anno, regione, t_femm, t_masc, t_both, val_rand, logico);
        }
    }
}
