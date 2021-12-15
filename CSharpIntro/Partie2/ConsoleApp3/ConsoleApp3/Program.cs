// See https://aka.ms/new-console-template for more information
int age;
string sex;
// demander l'age de l'utilisateur
Console.WriteLine("Quel est ton age?");
string ageString = Console.ReadLine();
age = int.Parse(ageString);
// demander le sex de l'utilisateur
Console.WriteLine("Quel est ton sex?");
sex = Console.ReadLine();
// comparer l'age de l'utilisateur et son sex pour afficher s'il est masculin ou feminin, majeur ou mineur
if( age >= 18)
{
    if(sex == "masculin")
    {
        Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
    } else if(sex == "feminin")
    {
        Console.WriteLine("Vous êtes une femme et vous êtes majeur.");
    }
    
} else
{
    if (sex == "masculin")
    {
        Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
    }
    else if (sex == "feminin")
    {
        Console.WriteLine("Vous êtes une femme et vous êtes mineur.");
    }
}

