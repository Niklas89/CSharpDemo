// See https://aka.ms/new-console-template for more information
Random randomNumber = new Random();
// Définir un nombre aléatoire entre 1 et 50
int numberToGuess = randomNumber.Next(1,51);
Boolean keepGuessing = true;
int attempt = 0; // nombre de tentatives pour trouver le nombre
// Demander à l’utilisateur de deviner ce nombre, continuer à demande tant que qu'il n'a pas trouvé
Console.WriteLine("Ecrivez 'Quit' pour quitter le program directement.");
while (keepGuessing)
{
    int guessedNumber = 0;
    Console.WriteLine("Devinez le nombre: ");
    string guessedNumberString = Console.ReadLine();
    // Taper "Quit" pour quitter le program
    if (guessedNumberString == "Quit")
    {
        keepGuessing = false;
    }
    // Vérifier si l'utilisateur a bien entré un nombre
    try
    {
        guessedNumber = int.Parse(guessedNumberString);
        // Vérifier que le nombre deviné se situe bien entre 1 et 50
        if ((guessedNumber >= 1) && (guessedNumber <= 50))
        {
            // Si le nombre deviné est bien égal au nombre défini, affiche le message "bravo"
            if (guessedNumber == numberToGuess)
            {
                Console.WriteLine("Bravo vous avez trouvé !");
                keepGuessing = false;
            }
            // Si le nombre deviné est inférieur ou égal au nombre défini
            else if (guessedNumber <= numberToGuess)
            {
                Console.WriteLine("C’est plus grand");
                attempt++;
                Console.WriteLine("Tentative : " + attempt + "\n");
            }
            // Sinon le nombre deviné peut uniquement être plus grand que le nombre défini
            else
            {
                Console.WriteLine("C’est plus petit");
                attempt++;
                Console.WriteLine("Tentative : " + attempt + "\n");
            }
        }
        else
        {
            Console.WriteLine("\n Le nombre deviné doit se situer entre 1 et 50. Veuillez réessayer.");
        }
    } catch (Exception ex)
    {
        Console.WriteLine("\n Vous n'avez pas entré un nombre, veuillez essayer à nouveau");
    }
    
}
Console.WriteLine("Tentatives au total : " + attempt);
