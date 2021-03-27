using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpcDosCPlus.Controls
{
   
    public partial class UCButton : UserControl
    {
        private readonly CpcDosCPlusListeObjets objets;
        public UCButton(CpcDosCPlusBouton button)
        {
            InitializeComponent();
            objets = new CpcDosCPlusListeObjets("fichier1.cpc");
            propertyGrid1.SelectedObject = button;
            //TODO: Gérer proprement le binding bi-directionnel
            int TailleX = int.Parse(button.SizeX);
            int TailleY = int.Parse(button.SizeY);
            
            button1.Text = button.Text;
            button1.Width = TailleX;
            button1.Height = TailleY;
            FormCollection nbforms = Application.OpenForms;
            Button monbouton;
            monbouton = new Button();

         
            nbforms["preview"].Controls.Add(monbouton);
            
            monbouton.Location = new Point(int.Parse(button.Px), int.Parse(button.Py));
            monbouton.Size = new Size(TailleX, TailleY);
            monbouton.Text = button.Text;
            string  CouleurFOND;
            CouleurFOND = button.BackColor;
            if (CouleurFOND != null)
            {
                textBox5.Text = button.BackColor.Substring(0, 3);
                textBox7.Text = button.BackColor.Substring(4, 3);
                textBox8.Text = button.BackColor.Substring(8, 3);
                button1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else
                 
                button1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
          
        }

        private void UCButton_Load(object sender, EventArgs e)
        {
            foreach (CpcDosCPlusObjet objet in objets)
            {
                comboBox1.Items.Add(objet);

            }
            
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     

            ComboBox list = sender as ComboBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                   // panel2.Controls.Add(obj.CreateUC());
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

