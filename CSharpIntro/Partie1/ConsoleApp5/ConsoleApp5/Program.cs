// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
string lastName;
string firstName;
// Demander le prénom à l'utilisateur
Console.WriteLine("Quel est ton prénom?");
firstName = Console.ReadLine();
// Demander le nom à l'utilisateur
Console.WriteLine("Quel est ton nom?");
lastName = Console.ReadLine();
// Calculer la date actuelle
DateTime today = DateTime.Now;
int year = today.Year;
int month = today.Month; 
int day = today.Day; 
// Afficher le message final avec nom, prénom et date
Console.WriteLine("Bonjour " + lastName + " " + firstName + ", nous sommes le "+day + "/" + month + "/" + year+", comment allez-vous ?");

