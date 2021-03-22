using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpcDosCPlus
{
    public partial class Form1 : Form
    {
        private readonly CpcDosCPlusListeObjets objets;
        private readonly CpcDosCPlusListeFenetre objetsfenetre;
        public Form1()
        {
            InitializeComponent();
            objets = new CpcDosCPlusListeObjets("fichier1.txt");
            objetsfenetre = new CpcDosCPlusListeFenetre("fichier1.txt");

            textBox1.Text = objets.ToCPCDosCPlus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (CpcDosCPlusObjet objet in objets)
            {
                listBox1.Items.Add(objet);

            }
            foreach (CpcDosCPlusObjetFenetre objetfenetre in objetsfenetre)
            {
                comboBox1.Items.Add(objetfenetre);

            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ListBox list = sender as ListBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                    panel1.Controls.Add(obj.CreateUC());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ComboBox list = sender as ComboBox;

            if (list != null)
            {
                CpcDosCPlusObjetFenetre obj = list.SelectedItem as CpcDosCPlusObjetFenetre;

                if (list != null)
                {
                    panel2.Controls.Add(obj.CreateUC());
                }
            }
        }
    }
}
