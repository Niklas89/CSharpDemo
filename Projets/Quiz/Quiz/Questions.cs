using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Questions
    {
        private Dictionary<int, string> _question;
        private string[,] _answer;
        private int[,] _correctAnswer;
        private int[,] _userAnswer;
        public int Score { get; set; }
        private int _scorePerQuestion;

        public Questions()
        {
            _question = new Dictionary<int, string>()
            {
                { 1, "Indiquez deux villes se situant en Suède :"},
                { 2, "Indiquez deux villes se situant en Norvège :" },
                { 3, "Indiquez deux villes se situant en Espagne :" },
                { 4, "Indiquez deux villes se situant en Allemagne :" },
                { 5, "Indiquez deux villes se situant en Italie :" },
                { 6, "Indiquez deux villes se situant en Autriche :"},
                { 7, "Indiquez deux villes se situant en Pologne :" },
                { 8, "Indiquez deux villes se situant en Belgique :" },
                { 9, "Indiquez deux villes se situant en Danemark :" },
                { 10, "Indiquez deux villes se situant en Finlande :" }
            };
            _answer = new string[,]
            {
                {"Stockholm","Sigtuna","Paris","Berlin","Nantes" },
                {"Oslo","Larvik","Paris","Berlin","Nantes" },
                {"Madrid","Barcelone","Paris","Berlin","Nantes" },
                {"Munich","Berlin","Stockholm","Sigtuna","Nantes" },
                {"Rome","Milan","Paris","Berlin","Nantes" },
                {"Vienne","Lustenau","Paris","Berlin","Nantes" },
                {"Sopot","Varsovie","Paris","Berlin","Nantes" },
                {"Bruxelles","Bruges","Paris","Berlin","Nantes" },
                {"Copenhague","Aarhus","Paris","Berlin","Nantes" },
                {"Helsinki","Espoo","Paris","Berlin","Nantes" },
            };
            _correctAnswer = new int[,]
            {
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
                {0,1},
            };
            _userAnswer = new int[10, 10];
            Score = 0;
            _scorePerQuestion = 0;
        }
        public void ShowQuestions()
        {
            foreach (KeyValuePair<int, string> question in _question)
            {
                Console.WriteLine("\n Question: {0} : {1}", question.Key, question.Value);
                Console.WriteLine("Choix : ");
                // Affichage de chaque réponse
                ShowAnswer(question.Key);
                // L'utilisateur doit écrire la première réponse
                int userFirstAnswer = EnterValue();
                //Entrer la première réponse dans le tableau des réponses de l'utilisateur
                _userAnswer[question.Key - 1, 0] = userFirstAnswer;
                // L'utilisateur doit écrire la deuxième réponse
                int userSecondAnswer = EnterValue();
                //Entrer la deuxième réponse dans le tableau des réponses de l'utilisateur
                _userAnswer[question.Key - 1, 1] = userSecondAnswer;
                // Additionner le score et affiche si la réponse est correcte.
                for (int columnCorrectAnswers = 0; columnCorrectAnswers < _correctAnswer.GetLength(1); columnCorrectAnswers++)
                {
                    // Si la première réponse de l'utilisateur est égale à la colonne correspondante des bonnes réponses
                    if (userFirstAnswer == columnCorrectAnswers + 1)
                    {
                        ChangeColorQuestions(true);
                        Console.WriteLine("La première réponse est correcte !");
                        Console.ResetColor();
                        Score++;
                    }
                    // Si la deuxième réponse de l'utilisateur est égale à la colonne correspondante des bonnes réponses
                    else if (userSecondAnswer == columnCorrectAnswers + 1)
                    {
                        ChangeColorQuestions(true);
                        Console.WriteLine("La deuxième réponse est correcte !");
                        Console.ResetColor();
                        Score++;
                    }
                    // Sinon c'est faux
                    else
                    {
                        ChangeColorQuestions(false);
                        Console.Write("Réponse ");
                        Console.Write(columnCorrectAnswers + 1);
                        Console.WriteLine(" est fausse !");
                        Console.ResetColor();
                    }

                }
            }
        }
        // Changer la couleure de fond dans le récapitulatif dépendament si le résultat est correct (vert) ou faux (rouge)
        private void ChangeColorRecap(bool outcome)
        {
            if(outcome == true)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
            } else if(outcome == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
        // Changer la couleure de fond dans la partie des questions dépendament si le résultat est correct (vert) ou faux (rouge)
        private void ChangeColorQuestions(bool outcome)
        {
            if (outcome == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (outcome == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
        // Rentrer une valeure correspondant à la réponse choisie pour chaque question
        private int EnterValue()
        {
            // L'utilisateur doit écrire la première réponse
            Console.WriteLine("Ecrivez le numéro correspondant à la réponse souhaitée : ");
            string userAnswerString = Console.ReadLine();
            int userAnswer = int.Parse(userAnswerString);
            return userAnswer;
        }
        // Affichage de chaque réponse
        private void ShowAnswer(int questionKey)
        {
            for (int columnAnswers = 0; columnAnswers < _answer.GetLength(1); columnAnswers++)
            {
                Console.WriteLine(columnAnswers + 1 + ") " + _answer[questionKey - 1, columnAnswers]);
            }
        }
        // Afficher le récapitulatif
        public void ShowRecap()
        {
            foreach (KeyValuePair<int, string> question in _question)
            {
                // Remettre le score de chaque question à 0 avant chaque question
                _scorePerQuestion = 0;
                Console.WriteLine("\n Question: {0} : {1}", question.Key, question.Value);
                Console.WriteLine("Choix : ");
                // Affichage de chaque réponse
                ShowAnswer(question.Key);
                // Additionner le score et affiche si la réponse est correcte.
                for (int columnCorrectAnswers = 0; columnCorrectAnswers < _correctAnswer.GetLength(1); columnCorrectAnswers++)
                {
                    // Si la première réponse de l'utilisateur est égale à la colonne correspondante des bonnes réponses
                    if (_userAnswer[question.Key - 1, 0] == columnCorrectAnswers + 1)
                    {
                        ChangeColorRecap(true);
                        Console.WriteLine("Réponse de l'utilisateur : " + _userAnswer[question.Key - 1, 0]);
                        Console.WriteLine("La première réponse est correcte !");
                        Console.ResetColor();
                        _scorePerQuestion++;
                    }
                    // Si la deuxième réponse de l'utilisateur est égale à la colonne correspondante des bonnes réponses
                    else if (_userAnswer[question.Key - 1, 1] == columnCorrectAnswers + 1)
                    {
                        ChangeColorRecap(true);
                        Console.WriteLine("Réponse de l'utilisateur : " + _userAnswer[question.Key - 1, 1]);
                        Console.WriteLine("La deuxième réponse est correcte !");
                        Console.ResetColor();
                        _scorePerQuestion++;
                    }
                    // Sinon c'est faux
                    else
                    {
                        ChangeColorRecap(false);
                        Console.Write("Vous avez répondu : ");
                        Console.WriteLine(columnCorrectAnswers + 1);
                        Console.WriteLine("C'est faux.");
                        Console.ResetColor();
                    }
                }
                ShowScorePerQuestion(question.Key);

            }
        }
        // Afficher le score de chaque question, une question vaut 2 points car il y a deux réponses possibles
        private void ShowScorePerQuestion(int questionKey)
        {
            Console.WriteLine("Score de la question " + questionKey + " : " + _scorePerQuestion + "/2");
        }


    }
}
