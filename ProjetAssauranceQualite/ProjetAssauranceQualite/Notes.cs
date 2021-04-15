using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetAssauranceQualite
{
   public class Notes
    {

        bonjour
           tout va bien
           
    
public int NumeroEtudiant {​​​​​​​ get; set; }​​​​​​​
        public int NumeroCours {​​​​​​​ get; set; }​​​​​​​
        private double laNote;
        public double LaNote {​​​​​​​ get {​​​​​​​ return laNote; }​​​​​​​ set {​​​​​​​ laNote = (value >= 0 && value <= 100) ? value : 0; }​​​​​​​ }​​​​​​​


        public Note(Etudiant etudiant, Cours cours, double laNote)
        {​​​​​​​
            this.LaNote = laNote;
            this.NumeroEtudiant = etudiant.NumeroEtudiant;
            this.NumeroCours = cours.NumeroCours;
        }​​​​​​​

         public static string AttribuerGrade()
		{
			string grade = "";
			if (CalculerMoyenne() <= 54) grade = "EC";
			else if (CalculerMoyenne() <= 59) grade = "DR";
			else if (CalculerMoyenne() <= 63) grade = "C-";
			else if (CalculerMoyenne() <= 66) grade = "C";
			else if (CalculerMoyenne() <= 69) grade = "C+";
			else if (CalculerMoyenne() <= 73) grade = "B-";
			else if (CalculerMoyenne() <= 76) grade = "B";
			else if (CalculerMoyenne() <= 79) grade = "B+";
			else if (CalculerMoyenne() <= 84) grade = "A-";
			else if (CalculerMoyenne() <= 89) grade = "A";
			else if (CalculerMoyenne() <= 100) grade ="A+";
			return grade;
		}

    }
}
