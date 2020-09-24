using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using link.models;

namespace link.DAO
{
    public class ArticleDao : IArticleDao
    {
        private Article[] listeArticles;

        public ArticleDao(Article[] listeArticles) {
            this.listeArticles = listeArticles;
        }
        
        
        public Article GetArticle(int identifiant) {
            return this.listeArticles.Where(art => art.Identifiant == identifiant).FirstOrDefault();
        }

        public List<Article> GetArticles() {
            var articles = listeArticles
                            .ToList();
            return articles;
        }

        public (int, double) GetPrixEtQuantite(string denomination) {
            var res = this.listeArticles
                            .Where(art => art.Denomination.Equals(denomination))
                            .Select(art => (art.Quantite, art.Prix))
                            .FirstOrDefault();
            return res;
        }

        public Tuple<int, double> GetPrixEtQuantiteT(string denomination) {
            var res = this.listeArticles
                            .Where(art => art.Denomination.Equals(denomination))
                            .Select(art => new Tuple<int, double>(art.Quantite, art.Prix))
                            .FirstOrDefault();
            return res;
        }

        public String GetArticlesQuantiteEntre() {
            StringBuilder res = new StringBuilder();
            res.AppendLine("Informations sur les articles : ");
            res.AppendLine("Article avec la quantite minimale : " + this.listeArticles.Min(art => art.Quantite));
            res.AppendLine("Article avec la quantite maximale : " + this.listeArticles.Max(art => art.Quantite));
            res.AppendLine("Prix moyen des articles: " + this.listeArticles.Average(art => art.Prix));


            return res.ToString();
        }
    }
}