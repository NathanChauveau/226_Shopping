namespace Shopping
{
    public class ShoppingBag:ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();


        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(bool empty = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (empty)
            {
                articlesReadyToCheckout.AddRange(_articles);
                _articles.Clear();
            }
            else
            {
                articlesReadyToCheckout.Add(_articles.Last());
                _articles.Remove(_articles.Last());
            }
            return articlesReadyToCheckout;
        }
        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        #endregion private attributes
    }
}
