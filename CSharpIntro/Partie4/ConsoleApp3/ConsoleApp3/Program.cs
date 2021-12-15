// See https://aka.ms/new-console-template for more information
// Créer une liste de nombres
List<int> numbers = new List<int> { 10, 5, 20, 2, 3 };
int totalNumbers = 0;
// Calculer la somme de tous les nombres de la liste
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
    totalNumbers += numbers[i];
}
// Afficher le résultat dans une phrase
Console.WriteLine("Total des nombres " + totalNumbers);
