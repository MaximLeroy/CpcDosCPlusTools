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
    public partial class UCTextBox : UserControl
    {
      

       
            private readonly CpcDosCPlusListeObjets objets;
            public UCTextBox(CpcDosCPlusTextBox textBox)
            {
                InitializeComponent();
                objets = new CpcDosCPlusListeObjets("fichier1.cpc");
                propertyGrid1.SelectedObject = textBox;
                //TODO: Gérer proprement le binding bi-directionnel
                int TailleX = int.Parse(textBox.SizeX);
                int TailleY = int.Parse(textBox.SizeY);

               textBox1.Text = textBox.Text;
                textBox1.Width = TailleX;
                textBox1.Height = TailleY;
                FormCollection nbforms = Application.OpenForms;
                TextBox montxtbox;
                montxtbox = new TextBox();


                nbforms["preview"].Controls.Add(montxtbox);

            montxtbox.Location = new Point(int.Parse(textBox.Px), int.Parse(textBox.Py));
            montxtbox.Size = new Size(TailleX, TailleY);
            montxtbox.Multiline = true;
            montxtbox.Text = textBox.Text;


            string CouleurFOND;
                CouleurFOND = textBox.BackColor;
                if (CouleurFOND != null)
                {
                    textBox5.Text = textBox.BackColor.Substring(0, 3);
                    textBox7.Text = textBox.BackColor.Substring(4, 3);
                    textBox8.Text = textBox.BackColor.Substring(8, 3);
                   textBox1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                }
                else

                  textBox1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
