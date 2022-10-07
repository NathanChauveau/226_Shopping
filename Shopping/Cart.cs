using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(Boolean empty = false)
        {
           /* if (articles != null)
            {
                foreach (var article in articles)
                {
                    _articles.Remove(article);
                }
            }
            else
            {
                throw new Exception();
            }
            return _articles;
        */
         List<Article> temparticle = new   List<Article>();
            temparticle.AddRange(_articles);
            _articles.Clear();
            return temparticle;
        
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }
        #endregion public methods
    }
}
