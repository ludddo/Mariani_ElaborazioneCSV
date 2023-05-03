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
        private void azione1_Click(object sender, EventArgs e)
        {
            Azione1();
        }
    }
}
