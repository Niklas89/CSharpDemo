// See https://aka.ms/new-console-template for more information
// Créer un tableau week contenant les jours 
string[] week = new string[7];
week[0] = "Lundi";
week[1] = "Mardi";
week[2] = "Mercredi";
week[3] = "Jedi";
week[4] = "Vendredi";
week[5] = "Samedi";
// Afficher le contenu de l’indice 1 et 4 du tableau dans la console sur 2 lignes différentes
Console.WriteLine("Contenu de l'indice 1: " + week[1]);
Console.WriteLine("Contenu de l'indice 4: " + week[4]);
// Afficher le contenu du 1er et du 4ᵉ élément du tableau dans la console sur 2 lignes différentes
Console.WriteLine("Contenu du premier élément du tableau: " + week[0]);
Console.WriteLine("Contenu du quatrième élément du tableau: " + week[3]);
week[3] = "Jeudi";
week[6] = "Dimanche"; // Ajout de "Dimanche" à la fin du tableau
// Afficher tout le tableau
for(int i = 0;i<7;i++)
{
    Console.WriteLine(week[i]);
}