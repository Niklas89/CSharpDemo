// See https://aka.ms/new-console-template for more information
bool keepAskingTornado = true;
string[,] fujita = new string[6, 2]
{
    {"F0","Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." },
    {"F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés." },
    {"F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées." },
    {"F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues." },
    {"F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances." },
    {"F5", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »." },
};
// Avec une boucle while vérifier si l'utilisateur rentre bien le type de la tornade, quitter le programme s'il rentre "Quit"
Console.WriteLine("Ecrivez 'Quit' pour quitter le program.");
while(keepAskingTornado) {
    // Inviter l’utilisateur à renseigner le type d’une tornade
    Console.WriteLine("Quel type de tornade souhaitez-vous consulter ?");
    string tornadoType = Console.ReadLine();
    if(tornadoType == "Quit") {
        keepAskingTornado = false;
    } else {
        // Afficher la description des dégâts causés par le type de tornade 
        for (int i = 0; i < 6; i++)
        {
            if (fujita[i, 0] == tornadoType)
            {
                Console.WriteLine(fujita[i, 1]);
                keepAskingTornado = false;
            } 
        }
    }
}
