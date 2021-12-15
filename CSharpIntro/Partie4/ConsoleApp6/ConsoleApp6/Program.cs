// See https://aka.ms/new-console-template for more information
public class Program
{
	// Créer une énumération week contenant les jours de la semaine
	enum Week { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };
	public static void Main()
	{
		// Afficher tous les éléments de week dans la console
		for (int i = 0; i < 7; i++)
		{
			Console.WriteLine(Enum.GetName(typeof(Week), i));
		}
		// Afficher la valeur 4 de l’énumération week
		Console.WriteLine(Enum.GetName(typeof(Week), 3));
	}
}