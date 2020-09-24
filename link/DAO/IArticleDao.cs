using System.Collections.Generic;
using link.models;

namespace link.DAO
{
    public interface IArticleDao
    {
         Article GetArticle(int identifiant);
         List<Article> GetArticles();
    }
}