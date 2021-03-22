using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CpcDosCPlus
{
    class CpcDosCPlusListeFenetre : List<CpcDosCPlusObjetFenetre>
    {
		public CpcDosCPlusListeFenetre(string path)
		{
			string[] lignes = File.ReadAllLines(path);
			
			bool chercheDebut = true;
			int debutObjet = -1;
			string typeObjet = string.Empty;
			
			for (int i = 0, length = lignes.Length; i < length; i++)
			{
				string ligne = lignes[i].Trim().ToLower();
				if (chercheDebut && ligne.Contains('/') && !ligne.StartsWith("rem/"))
				{
					string[] tmp = ligne.Split('/');
					if (tmp.Length > 2)
					{
						throw new Exception($"Je n'arrive pas à décoder cette ligne : {i}");
					}
					debutObjet = i;
					typeObjet = tmp[0];
					chercheDebut = false; // Maintenant on va chercher la fin
				}
				else if (!chercheDebut && ligne.StartsWith("fin/"))
				{
					switch (typeObjet)
					{
						case "fenetre":
							this.Add(new CpcDosCPlusFenetre(lignes.SubArray(debutObjet, i)));
							break;
						
							
						//default:
							//throw new Exception($"Type d'objet non pris en charge {typeObjet}");
					}
					chercheDebut = true;
				}
			}
		}

		public string ToCPCDosCPlus()
		{
			StringBuilder sb = new StringBuilder();

			foreach (CpcDosCPlusObjetFenetre objet in this)
			{
				sb.AppendLine(objet.ToCPCDosCPlus());
			}

			return sb.ToString();
		}
	}
}
