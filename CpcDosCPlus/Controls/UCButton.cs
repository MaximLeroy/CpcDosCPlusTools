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
        private readonly CpcDosCPlusListeFenetre objetsfenetre;
        public UCButton(CpcDosCPlusBouton button)
        {
            InitializeComponent();
            objetsfenetre = new CpcDosCPlusListeFenetre("fichier1.txt");

            //TODO: Gérer proprement le binding bi-directionnel
            int TailleX = int.Parse(button.Tx);
            int TailleY = int.Parse(button.Ty);
            textBox1.Text = button.Texte;
            button1.Text = button.Texte;
            button1.Width = TailleX;
            button1.Height = TailleY;
            textBox6.Text = button.CouleurFond;
            if (textBox6.Text != string.Empty)
            {
                textBox5.Text = button.CouleurFond.Substring(0, 3);
                textBox7.Text = button.CouleurFond.Substring(4, 3);
                textBox8.Text = button.CouleurFond.Substring(8, 3);
                button1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else
                 
                button1.BackColor = Color.FromArgb(int.Parse(textBox5.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
          
        }

        private void UCButton_Load(object sender, EventArgs e)
        {
            foreach (CpcDosCPlusObjetFenetre objetfenetre in objetsfenetre)
            {
                comboBox1.Items.Add(objetfenetre);

            }
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     

            ComboBox list = sender as ComboBox;

            if (list != null)
            {
                CpcDosCPlusObjetFenetre obj = list.SelectedItem as CpcDosCPlusObjetFenetre;

                if (list != null)
                {
                   // panel2.Controls.Add(obj.CreateUC());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
