using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetAssauranceQualite
{
    class Etudiant
    {
        
        public override string ToString()
		{
			return "\n\tNumero Etudiant "+this.NumeroEtudiant+"\n\tNom : "+this.Nom+"\n\tPrenom : "+this.Prenom;
		}

		public static void AfficherListeEtudiant(List<Etudiant> listeEtudiants)
		{
			if (listeEtudiants.Count < 1)
			{
				Console.WriteLine("Aucun etudiant disponible dans votre base de donnee\n");
			}
			foreach (Etudiant etud in listeEtudiants)
			{
				Console.WriteLine(etud.ToString());
			}
		}
    }
}
