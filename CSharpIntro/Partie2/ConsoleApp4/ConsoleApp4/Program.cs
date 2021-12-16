// See https://aka.ms/new-console-template for more information
const string login = "log";
const string password = "pass";
// demander à l'utilisateur de renseigner son identifiant
Console.WriteLine("Renseignez votre identifiant:");
string loginUser = Console.ReadLine();
// demander à l'utilisateur de renseigner son mot de passe
Console.WriteLine("Renseignez votre mot de passe:");
string passwordUser = Console.ReadLine();
// vérifier si le mot de passe et l'identifiant sont corrects
switch(loginUser, passwordUser)
{
    case (login, password):
        Console.WriteLine("Bienvenue à la Manu");
        break;
    default:
        Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        break;
}

