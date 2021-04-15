using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetAssauranceQualite
{
   public class Notes
    {
        bonjour
           tout va bien
           
        [19:28] Amadou Dioulde Bah
    
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

<https://teams.microsoft.com/l/message/19:d7fa6a1d30cc420ba227816384730768@thread.tacv2/1618529332835?tenantId=ad8a84ef-f1f3-4b14-ad08-b99ca66f7e30&amp;groupId=ca26abd3-2e3a-4ce9-a059-9304504b53ff&amp;parentMessageId=1618522110821&amp;teamName=Assurance Qualité Logicielle&amp;channelName=Général&amp;createdTime=1618529332835>  

    }
}
