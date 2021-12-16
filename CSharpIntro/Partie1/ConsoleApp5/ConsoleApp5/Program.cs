// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
string lastName;
string firstName;
Boolean keepAsking = true;
Console.WriteLine("Ecrivez 'Quit' pour quitter le program.");
// Boucle while pour quitter le program si jamais l'utilisateur rentre "Quit" ou recommencer s'il ne rentre rien
do
{
    // Demander le prénom à l'utilisateur
    Console.WriteLine("Quel est ton prénom?");
    firstName = Console.ReadLine();
    if (firstName == "Quit")
    {
        keepAsking = false;
    }
    else if (firstName == "" || firstName == " ")
    {
        Console.WriteLine("Vous devez mettre du texte !");
        keepAsking = true;
    }
    else
    {
        // Demander le nom à l'utilisateur
        Console.WriteLine("Quel est ton nom?");
        lastName = Console.ReadLine();
        if (lastName == "Quit")
        {
            keepAsking = false;
        }
        else if (lastName == "" || lastName == " ")
        {
            Console.WriteLine("Vous devez mettre du texte !");
            keepAsking = true;
        }
        else
        {
            // Calculer la date actuelle 
            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            int day = today.Day;
            // Afficher le message final avec nom, prénom et date
            Console.WriteLine("Bonjour " + lastName + " " + firstName + ", nous sommes le " + day + "/" + month + "/" + year + ", comment allez-vous ?");
            keepAsking = false;

        }
    }
} while (keepAsking);