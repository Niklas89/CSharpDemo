// See https://aka.ms/new-console-template for more information
string month;
// demander à l'utilisateur de renseigner un mois de l'année
Console.WriteLine("Renseignez un mois:");
month = Console.ReadLine();
// vérifier si le mois saisi correspond bien à une saison de l'année
switch (month)
{
    case "janvier":
        Console.WriteLine("La saison du mois saisi est l'HIVER.");
        break;
    case "février":
        Console.WriteLine("La saison du mois saisi est l'HIVER.");
        break;
    case "mars":
        Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
        break;
    case "avril":
        Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
        break;
    case "mai":
        Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
        break;
    case "juin":
        Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
        break;
    case "juillet":
        Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
        break;
    case "aout":
        Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
        break;
    case "septembre":
        Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
        break;
    case "octobre":
        Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
        break;
    case "novembre":
        Console.WriteLine("La saison du mois saisi est l'HIVER.");
        break;
    case "decembre":
        Console.WriteLine("La saison du mois saisi est l'HIVER.");
        break;
    default:
        Console.WriteLine("Ce mois n'est pas valide.");
        break;
}

