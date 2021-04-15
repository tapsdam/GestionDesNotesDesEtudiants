using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetAssauranceQualite
{
    class Cours
    {
        private static int codeIncrement;
		private int CodeCours { get; }
		public int NumeroCours { get; set; }
		public string TitreCours { get; set; }

		public Cours(int numeroCours, string titreCours)
		{
			this.CodeCours = ++codeIncrement;
			this.NumeroCours = numeroCours;
			this.TitreCours = titreCours;
		}
    }
}
