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

         //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
            nbforms["preview"].Controls.Add(monbouton);
            
            monbouton.Location = new Point(int.Parse(button.Px), int.Parse(button.Py));
            monbouton.Size = new Size(TailleX, TailleY);
            monbouton.Text = button.Text;
          
            string CouleurFOND;
            string red = "255";
            string green = "255";
            string blue = "255";
            CouleurFOND = button.BackColor;
            textBox1.Text = CouleurFOND;
            if (CouleurFOND == null)
            {
               
                CouleurFOND = "255,255,255";

            }
            else
                
            red = CouleurFOND.Substring(0, 3);
            green = CouleurFOND.Substring(4, 3);
            blue = CouleurFOND.Substring(8, 3);
          

             
            button1.BackColor = Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue));
            monbouton.BackColor = Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue));

     
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

