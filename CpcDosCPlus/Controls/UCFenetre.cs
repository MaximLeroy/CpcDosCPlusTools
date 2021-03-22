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
        public UCFenetre(CpcDosCPlusFenetre fenetre )
        {
            InitializeComponent();
            //TODO: Gérer proprement le binding bi-directionnel
            int TailleX = int.Parse(fenetre.Tx);
            int TailleY = int.Parse(fenetre.Ty);

            label1.Text = fenetre.Titre;
            panel1.Width = TailleX;
            panel1.Height = TailleY;
            panel2.Width = TailleX;
        }

        private void UCFenetre_Load(object sender, EventArgs e)
        {
          
        }
    }
}
