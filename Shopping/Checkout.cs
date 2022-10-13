﻿namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
            UpdateBalance();
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (empty == true)
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

        public float Balance
        {
            get
            {
                return this._balance;
            }
        }

        public void StartCashingProcess()
        {
            _balance = 0f;
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                foreach (Article article in _articles)
                {
                    _balance = _balance + article.Price;
                }
            }
        }
        #endregion private methods
    }
}
