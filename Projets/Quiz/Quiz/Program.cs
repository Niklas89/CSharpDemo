using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{

	public class Program
	{
		public static void Main()
		{
			//string[] readText = File.ReadAllLines(path);
			// Instancier la classe Questions
			Questions questions = new Questions();
			// Afficher chaque questoin
			questions.ShowQuestions();
			// Afficher le score
			Console.WriteLine(questions.Score + "/20");
			// Afficher le récapitulatif
			questions.ShowRecap();
			// Afficher le score total
			Console.WriteLine("SCORE TOTAL : " + questions.Score + "/20");
		}
	}

}