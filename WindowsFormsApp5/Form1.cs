using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarray_Click(object sender, EventArgs e)
        {
            int[] Sayilar=new int[5];
            for(int i = 0; i < 5; i++)
            {
                Sayilar[i] = i;
            }
            foreach(int sayi in Sayilar)
            {
                listbox.Items.Add(sayi);
            }

        }

        private void btnarraylist_Click(object sender, EventArgs e)
        {
            ArrayList ArrayDizi = new ArrayList();
            ArrayDizi.Add(5);
            ArrayDizi.Add(5.25);
            ArrayDizi.Add("selenay");

            foreach(object list in ArrayDizi)
            {
                listbox.Items.Add(list);
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            List<string> Liste = new List<string>();
            Liste.Add("5");
            Liste.Add("selenay");
            Liste.Add("7");
            foreach(var list in Liste)
            {
                listbox.Items.Add(list);
            }
        }
        private List<Button> Dugmeler = new List<Button>();
        private void btnbutonlar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dugmeler.Clear();
            for (int i = 0; i < 7; i++)
            {
                Button btn = new Button();
                btn.Text = ("Görev" + i).ToString();
                btn.Name = "button" + i;
                btn.Tag = i;
                btn.Click += new EventHandler(btnListi_Click);
                Dugmeler.Add(btn);
                //normal panel yerine toolbox da flow panel ekle üst üste cıkmasın. panel 1in türüne bak design da.
                //flowpanel
                panel1.Controls.Add(Dugmeler[i]);
            }
            MessageBox.Show(Dugmeler.Count + " yeni buton eklendi.");
            btnrenk.Show();
        }
        private void btnListi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btn0")
            {
                MessageBox.Show("Birinci butona tiklandi.");
            }
            else
            {
                MessageBox.Show("Tiklanan buton numarasi : " + btn.Tag);
            }
        }
        private void btnrenk_Click(object sender, EventArgs e)
        {
            int Mavi = 30;
            foreach (Button b in Dugmeler)
            {
                //b.BackColor = Color.FromArgb( b.BackColor.R, b.BackColor.G, Mavi );
                //b.BackColor = Color.FromArgb( 128, 128, Mavi );
                b.BackColor = Color.FromArgb(Mavi / 4, Mavi / 4, Mavi);
                Mavi += 30;
            }
        }
    }
}
