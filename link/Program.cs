using System;
using System.Linq;
using System.Collections.Generic;
using link.models;
using link.DAO;

namespace link
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeEntiers = new List<int>
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            List<int> listeAnnee = new List<int>
                {2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020};

            // Example
            List<int> listeEntiersPair = (from unEntier in listeEntiers
                                        where ( unEntier % 2 == 0)
                                        select unEntier).ToList();

            /** foreach (int val in listeEntiersPair) {
                Console.WriteLine(val);
            } */

            // Exercice 3.1
            List<int> listePremiers = (from unEntier in listeEntiers
                                      where (Premier(unEntier))
                                      select unEntier).ToList();
            
            Console.WriteLine("Nombre premier : ");
            foreach (int premier in listePremiers)
            {
                Console.WriteLine(premier);
            }

            // Exercice 3.2
            var requeteBissextile = from uneAneee in listeAnnee
                                    where DateTime.IsLeapYear(uneAneee)
                                    select uneAneee;
            
            foreach (int annee in requeteBissextile.ToList()) {
                Console.WriteLine(annee);
            }

            //Exercice 3.3
            List<int> divisibleParCinq = listeEntiers.
                                        Where(valeur => valeur % 5 == 0)
                                        .ToList();

            foreach (int entier in divisibleParCinq) {
                Console.WriteLine(entier);
            }

            //Exercice 3.4
            Article[] testArticles = new Article[5];

            testArticles[0] = new Article(1, "test", 25);
            testArticles[1] = new Article(2, "test2", 65);

            IArticleDao dao = new ArticleDao(testArticles);

            var articles = dao.GetArticles();

            foreach(var article in articles) 
            {
                Console.WriteLine(article);
            }


        }

        public static int NombreFacteur(int N)
        {
            int Count = 2, I;
            double Racine = Math.Sqrt(N);
            for (I = 2; I <= Racine; I++) if (N % I == 0) Count++;
            return Count;
        }
 
        public static bool Premier(int N)
        {   if (N == 1)
            {
                return false;
            }
            return (NombreFacteur(N) == 2);
        } 
    }
}
