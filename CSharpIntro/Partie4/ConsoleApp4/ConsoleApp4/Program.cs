// See https://aka.ms/new-console-template for more information
// Création d'une liste pour les nombres que l'utilisateur souhaite multiplier
List<int> multiplyNumbers = new List<int>();
string numberString;
int number;
int multiplicationResult = 1;
Boolean keepAsking = true;
// Demander à l’utilisateur les nombres qu’il souhaite multiplier, tapez "Quit" pour quitter le program
Console.WriteLine("Ecrivez 'Quit' pour quitter le program.");
while (keepAsking)
{
    Console.WriteLine("Entrez un nombre que vous souhaitez multiplier:");
    numberString = Console.ReadLine();
    if(numberString == "Quit")
    {
        keepAsking = false;
    } else if(numberString == "")
    {
        Console.WriteLine("Vous n'avez rien écrit, veuillez entrer un nombre à multiplier svp.");
    } else
    {
        // vérifier si l'utilisateur a bien entré un nombre
        try
        {
            number = int.Parse(numberString);
            multiplyNumbers.Add(number);
        } catch (Exception ex)
        {
            Console.WriteLine("Ce n'est pas un nombre, veuillez entrer un nombre svp.");
        }           
    }
}
// Calculer le résultat de la multiplication et l’afficher en rappelant tous les nombres
Console.Write("Les nombres à multiplier sont : ");
for (int i = 0; i < multiplyNumbers.Count; i++)
{
    Console.Write(multiplyNumbers[i] + ", ");
    multiplicationResult *= multiplyNumbers[i];
     
}
Console.WriteLine("Résultat de la multiplication : " + multiplicationResult);
