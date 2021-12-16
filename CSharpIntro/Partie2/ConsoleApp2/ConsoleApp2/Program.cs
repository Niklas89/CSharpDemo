// See https://aka.ms/new-console-template for more information
int age;
// demander l'age de l'utilisateur
Console.WriteLine("Veuillez renseigner votre âge :");
string ageString = Console.ReadLine();
age = int.Parse(ageString);
// comparer l'age de l'utilisateur avec l'age légal pour afficher le message correspondant
if(age >= 18)
{
    Console.WriteLine("Vous avez "+age+" ans, vous êtes donc majeur. ");
} else
{
    Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur. ");
}
