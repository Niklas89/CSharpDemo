// See https://aka.ms/new-console-template for more information
List<string> languages = new List<string> { "HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java" };
// Afficher toute la liste languages
for (int i = 0; i < languages.Count; i++)
{
    Console.WriteLine(languages[i]);
}
// Supprimer, modifier et ajouter les éléments
Console.WriteLine("Le 4ème élément de la liste : " + languages[3]);
Console.WriteLine("L’élément à l’index 4 de la liste : " + languages[4]);
languages.Remove("Bootstrap");
// Modifier Javacrit en Javascript :
languages[languages.IndexOf("Javacrit")] = "Javascript";
// on peut faire aussi: languages[2] = "Javascript";
languages.Add("C");
// Afficher la liste
// cest  mieux foreach pour les tableaux
foreach (var language in languages) Console.WriteLine(language);
