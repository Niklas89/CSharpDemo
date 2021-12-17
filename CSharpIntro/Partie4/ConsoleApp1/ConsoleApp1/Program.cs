// See https://aka.ms/new-console-template for more information
// Créer un tableau week contenant les jours 
string[] week = new string[7];
week[0] = "Lundi";
week[1] = "Mardi";
week[2] = "Mercredi";
week[3] = "Jedi";
week[4] = "Vendredi";
week[5] = "Samedi";
string[] week2 = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
// Afficher le contenu de l’indice 1 et 4 du tableau dans la console sur 2 lignes différentes
Console.WriteLine("Contenu de l'indice 1: " + week[1]);
Console.WriteLine("Contenu de l'indice 4: " + week[4]);
// Afficher le contenu du 1er et du 4ᵉ élément du tableau dans la console sur 2 lignes différentes
Console.WriteLine("Contenu du premier élément du tableau: " + week[0]);
Console.WriteLine("Contenu du quatrième élément du tableau: " + week[3]);
week[3] = "Jeudi";
// Ajout de "Dimanche" à la fin du tableau :
week[6] = "Dimanche"; 
// si on veut resize le tableau d'une autre manière : 
Array.Resize(ref week2, 7);
week[3] = "Jeudi";
week2[6] = "Dimanche";
// Afficher tout le tableau avec boucle for :
for (int i = 0;i<7;i++)
{
    Console.WriteLine(week[i]);
}
// c'est mieux foreach pour les tableaux, car ca sarrete automatique a la fin du tableau :
Console.WriteLine("\n Utilisation de foreach pour afficher le tableau : ");
foreach (string day in week2)
{
    Console.WriteLine(day);
}