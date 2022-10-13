namespace Shopping
{
    public class Checkout : ShoppingBag
    {
        #region private attributes
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            base.Add(articles);
            UpdateBalance();
        }

        public float Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void StartCashingProcess()
        {
            
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                foreach (Article article in base.Articles)
                {
                    _balance = _balance + article.Price;
                }
            }
        }
        #endregion private methods
    }
}
