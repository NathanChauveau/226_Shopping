﻿using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private bool _released = false;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (clearCart) 
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

        public void Release()
        {
            _released = true;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public bool? IsReleased
        {
            get
            {
                return _released;
            }
        }
        #endregion public methods
    }
}
