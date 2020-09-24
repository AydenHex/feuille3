using System;
using System.Collections.Generic;
using link.models;

namespace link.DAO
{
    public interface IArticleDao
    {
         Article GetArticle(int identifiant);
         List<Article> GetArticles();
         (int, double) GetPrixEtQuantite(string denomination);
         Tuple<int, double> GetPrixEtQuantiteT(string denomination);

         String GetArticlesQuantiteEntre();
    }
}