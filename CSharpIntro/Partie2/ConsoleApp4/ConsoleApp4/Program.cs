// See https://aka.ms/new-console-template for more information
string login = "log";
string password = "pass";
// demander à l'utilisateur de renseigner son identifiant
Console.WriteLine("Renseignez votre identifiant:");
login = Console.ReadLine();
// demander à l'utilisateur de renseigner son mot de passe
Console.WriteLine("Renseignez votre mot de passe:");
password = Console.ReadLine();
// vérifier si le mot de passe et l'identifiant sont corrects
switch(login)
{
    case "log":
        switch(password)
        {
            case "pass":
                Console.WriteLine("Bienvenue à la Manu.");
                break;
            default: Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                break;
        }
        break;
    default:
        Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        break;
}

