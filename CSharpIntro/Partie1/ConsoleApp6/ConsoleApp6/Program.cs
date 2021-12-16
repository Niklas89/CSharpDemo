// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
string lastName;
string firstName;
string dateBirthString;
int dateBirth = 0;
Console.WriteLine("Ecrire 'Quit' pour quitter le program.");
Console.WriteLine("Vous devez remplir toutes les cases sinon il faut recommencer.");
Boolean keepAsking = true;
do
{
    // Demander à l'utilisateur son prénom
    Console.WriteLine("Veuillez saisir votre prénom :");
    firstName = Console.ReadLine();
    if(firstName == "Quit")
    {
        keepAsking = false;
    } else
    {
        // Demander à l'utilisateur son nom
        Console.WriteLine("Veuillez saisir votre nom :");
        lastName = Console.ReadLine();
        if(lastName == "Quit")
        {
            keepAsking = false;
        } else
        {
            try
            {
                // Demander à l'utilisateur sa date de naissance
                Console.WriteLine("Veuillez saisir votre annee de naissance :");
                dateBirthString = Console.ReadLine();
                if (dateBirthString == "Quit")
                {
                    keepAsking = false;
                } else if(firstName == "" || lastName == "") {
                    Console.WriteLine("Vous n'avez pas rempli toutes les cases, vous devez recommencer. \n");
                    keepAsking = true;
                } else
                {
                    dateBirth = int.Parse(dateBirthString);
                    // Afficher les renseignements avec les détails entrés ci-dessus
                    Console.WriteLine("Fiches de renseignement \n * Nom : " + lastName + "\n \n * Prenom : " + firstName + "\n \n * Age : " + (DateTime.Now.Year - dateBirth));
                    keepAsking = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Veuillez entrer un nombre pour la date de naissance svp. \n");
            }
        }
    }
} while (keepAsking);