// See https://aka.ms/new-console-template for more information
Random randomNumber = new Random();
// Définir un nombre aléatoire entre 1 et 50
int numberToGuess = randomNumber.Next(1,50);
int guessedNumber;
Boolean keepGuessing = true;
int attempt = 0; // nombre de tentatives pour trouver le nombre
// Demander à l’utilisateur de deviner ce nombre, continuer à demande tant que qu'il n'a pas trouvé
while(keepGuessing)
{
    Console.WriteLine("Devinez le nombre: ");
    string guessedNumberString = Console.ReadLine();
    guessedNumber = int.Parse(guessedNumberString);
    if (guessedNumber == numberToGuess)
    {
        Console.WriteLine("Bravo vous avez trouvé !");
        keepGuessing = false;
    }
    else if (guessedNumber <= numberToGuess)
    {
        Console.WriteLine("C’est plus grand");
    }
    else
    {
        Console.WriteLine("C’est plus petit");
    } 
    attempt++;
    Console.WriteLine("Tentative : " + attempt);
}
Console.WriteLine("Tentatives au total : " + attempt);
