// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
string lastName;
string firstName;
int dateBirth;
// Demander à l'utilisateur son prénom
Console.WriteLine("Quel est ton prénom?");
firstName = Console.ReadLine();
// Demander à l'utilisateur son nom
Console.WriteLine("Quel est ton nom?");
lastName = Console.ReadLine();
// Demander à l'utilisateur sa date de naissance
Console.WriteLine("Quel est ton annee de naissance?");
string dateBirthString = Console.ReadLine();
dateBirth = int.Parse(dateBirthString);
// Afficher les renseignements avec les détails entrés ci-dessus
Console.WriteLine("Fiches de renseignement \n * Nom: " + lastName + "\n * Prenom: " + firstName + "\n * Age : " + dateBirth);
