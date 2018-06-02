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

namespace bensamaatti
{
    public partial class Form1 : Form
    {
       
        double mittari;
        string polttoaine;
        DateTime aika = DateTime.Now;
        double tyyppi;
        double tulos;
        double saldo = 100;
        public Form1()
        {
            InitializeComponent();

            saldoMaara.Text = saldo.ToString("F1");


        }
        private void StarttiOk()
            {
                if ((valitseMittari.SelectedItem != null) && (e95.Checked || e98.Checked || diesel.Checked))
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }

        private void TeeTiedosto()
        {
            if (!File.Exists("c:/Temp/bensis.txt"))
            {
                using (TextWriter tw = new StreamWriter("c:/Temp/bensis.txt"))
                {
                    tw.WriteLine("KUITTI\n\n" + aika + "\n" + polttoaine + "\n" + valitseMittari.SelectedItem + "\n" + "veloitettu: " + label7.Text + "euroa\n" + "tankattu: " + label5.Text + "litraa", "NESTE Iisalmi");
                }
            }

            else
            {
                using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(@"C:\Temp\bensis.txt", true))
                {
                    file.WriteLine("KUITTI\n\n" + aika + "\n" + polttoaine + "\n" + valitseMittari.SelectedItem + "\n" + "veloitettu: " + label7.Text + "euroa\n" + "tankattu: " + label5.Text + "litraa", "NESTE Iisalmi");
                }
            }

                
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((valitseMittari.SelectedItem != null) && (e95.Checked || e98.Checked || diesel.Checked))
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Valitse mittari ja polttoaine ennen tankkausta");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StarttiOk();
            e95.Enabled = true;
            e98.Enabled = true;
            diesel.Enabled = true;
        }

        private void valitsePolttoaine_SelectedIndexChanged(object sender, EventArgs e)
        {
            StarttiOk();

        }

        private void label4_Click(object sender, EventArgs e)
        { 
        }

        public void timer1_Tick_1(object sender, EventArgs e)
        {
            
           mittari  = Convert.ToDouble(label5.Text) +0.1;

            label5.Text = mittari.ToString("F1");
            PumppuSumma();
            if (tulos >= 99.95 || saldo <= 0.02)
            {
                timer1.Stop();
                MessageBox.Show("Saldosi on käytetty"); 
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult result1 = MessageBox.Show("Lopetetaanko tankkaus ja tulostetaanko kuitti?", "NESTE Iisalmi",
                MessageBoxButtons.YesNoCancel);
            if (result1 == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("KUITTI\n\n" + aika + "\n" + polttoaine + "\n" + valitseMittari.SelectedItem + "\n" + "veloitettu: " + label7.Text +"euroa\n" + "tankattu: " + label5.Text+"litraa", "NESTE Iisalmi");
                TeeTiedosto();
                if (result2 == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if (result1 == DialogResult.No)
            {
                Application.Exit();
            }
            if (result1 == DialogResult.Cancel)
            {
                return;
            }
        }
        private void e95_CheckedChanged(object sender, EventArgs e)
        {
            if (e95.Checked == true)
            {
                polttoaine = "e95";
                tyyppi = 1.49;
                e98.Enabled = false;
                diesel.Enabled = false;
                StarttiOk();
            }
            else {
                StarttiOk();
                e98.Enabled = true;
                diesel.Enabled = true;

            }
        }
        private void e98_CheckedChanged(object sender, EventArgs e)
        {
            if (e98.Checked == true)
            {
                polttoaine = "e98";
                tyyppi = 1.55;
                e95.Enabled = false;
                diesel.Enabled = false;
                StarttiOk();
            }
            else
            {
                e95.Enabled = true;
                diesel.Enabled = true;
                StarttiOk();
            }
            }

        private void diesel_CheckedChanged(object sender, EventArgs e)
        {
            if (diesel.Checked == true)
            {
                polttoaine = "diesel";
                tyyppi = 1.19;
                e95.Enabled = false;
                e98.Enabled = false;
                StarttiOk();
            }
            else
                {
                    e98.Enabled = true;
                    e95.Enabled = true;
                StarttiOk();
            }
            }
        private void PumppuSumma()
        {

            tulos = tyyppi * mittari;
            saldo = saldo - (tyyppi / 10);
            saldoMaara.Text = saldo.ToString("F1");
            label7.Text = tulos.ToString("F1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

}
