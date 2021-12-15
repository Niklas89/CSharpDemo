// See https://aka.ms/new-console-template for more information
// Liste avec tous les nombres
List<int> numbers = new List<int> { 10, 5, 20, 2, 3 };
// Création d'une liste pour les nombres que l'utilisateur souhaite multiplier
List<int> multiplyNumbers = new List<int>();
int multiplicationResult = 1;
// Demander à l’utilisateur les nombres qu’il souhaite multiplier, s'il répond "oui" les stocker dans la liste
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
    Console.WriteLine("Souhaitez-vous multiplier ce nombre?");
    string reply = Console.ReadLine();
    if(reply == "oui")
    {
        multiplyNumbers.Add(numbers[i]);
    } 
}
// Calculer le résultat de la multiplication et l’afficher en rappelant tous les nombres
for (int i = 0; i < multiplyNumbers.Count; i++)
{
    Console.WriteLine("Nombre à multiplier : "+multiplyNumbers[i]);
    multiplicationResult *= multiplyNumbers[i];
     
}
Console.WriteLine("Résultat de la multiplication " + multiplicationResult);
