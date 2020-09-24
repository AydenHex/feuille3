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
    }
}