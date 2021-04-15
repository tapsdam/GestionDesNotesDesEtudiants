static void Main(string[] args)
		{
			string reponse = "";
			Etudiant etudiant1;
			List<Etudiant> wenkouni = new List<Etudiant>();
			do
			{
				Console.Write("Num : ");
				int num = int.Parse(Console.ReadLine());
				Console.Write("Nom : ");
				string nom = Console.ReadLine();
				Console.Write("Prenom : ");
				string prenom = Console.ReadLine();

				 etudiant1 = new Etudiant(num, nom, prenom);

				
				wenkouni.Add(etudiant1);
				Console.WriteLine("voulez vous continuer ");
				reponse = Console.ReadLine();
			} while (reponse != "N" );
