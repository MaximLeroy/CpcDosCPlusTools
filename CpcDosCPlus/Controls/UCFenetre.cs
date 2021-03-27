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
    
    public partial class UCFenetre : UserControl
    {
     
        public UCFenetre(CpcDosCPlusImageBox mafenetre )
        {
            
            InitializeComponent();
            //TODO: Gérer proprement le binding bi-directionnel
            int TailleX = int.Parse(mafenetre.SizeX);
            int TailleY = int.Parse(mafenetre.SizeY);

            label1.Text = mafenetre.Title;
            panel4.Width = TailleX;
            panel4.Height = TailleY;
            panel2.Width = TailleX;
            Preview apercu = new Preview();
            apercu.Show();
            apercu.Width = TailleX;
            apercu.Height = TailleY;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
