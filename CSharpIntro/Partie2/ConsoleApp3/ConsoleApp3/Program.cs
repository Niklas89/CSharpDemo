// See https://aka.ms/new-console-template for more information
int age = 0;
string gender;
Boolean keepAskingAge = true;
Boolean keepAskingGender = true;
// Demander en boucle de rentrer un nombre pour l'age, Exception prend l'erreur et redemande de saisir
do
{
    try
    {
        // demander l'age de l'utilisateur
        Console.WriteLine("Veuillez renseigner votre age :");
        string ageString = Console.ReadLine();
        age = int.Parse(ageString);
        keepAskingAge = false;
    }
    catch (Exception e)
    {
        Console.WriteLine("Veuillez entrer un nombre pour votre age svp. \n");
    }
} while (keepAskingAge);
// Demander en boucle de renseigner masculin ou feminin, si ca ne correspond pas il faut reessayer
do
{
    // demander le sex de l'utilisateur
    Console.WriteLine("Veuillez renseigner votre sexe (masculin / feminin) :");
    gender = Console.ReadLine();
    // comparer l'age de l'utilisateur et son sex pour afficher s'il est masculin ou feminin, majeur ou mineur
    if (age >= 18)
    {
        if (gender == "masculin")
        {
            Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
            keepAskingGender = false;
        }
        else if (gender == "feminin")
        {
            Console.WriteLine("Vous êtes une femme et vous êtes majeur.");
            keepAskingGender = false;
        }
        else
        {
            Console.WriteLine("Vous devez indiquer si vous êtes 'masculin' ou 'feminin'");
            keepAskingGender = true;
        }

    }
    else
    {
        if (gender == "masculin")
        {
            Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
            keepAskingGender = false;
        }
        else if (gender == "feminin")
        {
            Console.WriteLine("Vous êtes une femme et vous êtes mineur.");
            keepAskingGender = false;
        }
        else
        {
            Console.WriteLine("Vous devez indiquer si vous êtes 'masculin' ou 'feminin'");
            keepAskingGender = true;
        }
    }
} while (keepAskingGender);
