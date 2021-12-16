// See https://aka.ms/new-console-template for more information
int result = 0;
int number;
string numberString;
Boolean keepAsking = true;
while(keepAsking)
{   
    try
    {
        // demander à l'utilisateur d'entrer un nombre à additionner
        Console.WriteLine("Entrez un nombre:");
        numberString = Console.ReadLine();
        number = int.Parse(numberString);
        result += number;
        // demander à l'utilisateur s'il veut ajouter encore un nombre
        Console.WriteLine("Ajouter encore un nombre?");
        string addNumber = Console.ReadLine();
        // Tant que l’utilisateur ne répond pas non le program continue à demander un nombre
        if (addNumber == "non")
        {
            keepAsking = false;
        }
        else
        {
            keepAsking = true;
        }
    } catch (Exception ex)
    {
        Console.WriteLine("Vous n'avez pas entré un nombre, veuillez réessayer.");
    }
}
Console.WriteLine("Le resultat est " + result);

