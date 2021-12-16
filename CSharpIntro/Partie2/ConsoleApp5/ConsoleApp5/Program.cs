// See https://aka.ms/new-console-template for more information
string month;
// demander à l'utilisateur de renseigner un mois de l'année
Console.WriteLine("Renseignez un mois:");
month = Console.ReadLine();
// vérifier si le mois saisi correspond bien à une saison de l'année
switch (month)
{
    case "novembre":
    case "decembre":
    case "janvier":
    case "février":
        Console.WriteLine("La saison du mois saisi est l'HIVER.");
        break;
    case "mars":
    case "avril":
    case "mai":
        Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
        break;
    case "juin":
    case "juillet":
    case "aout":
        Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
        break;
    case "septembre":
    case "octobre":
        Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
        break;
    default:
        Console.WriteLine("Ce mois n'est pas valide.");
        break;
}