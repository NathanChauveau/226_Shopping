namespace Shopping
{
    public class PaymentTerminal
    {
        #region private attributes
        private Checkout _checkout = new Checkout();
        #endregion private attributes

        #region public methods
        public PaymentTerminal(Checkout checkout)
        {
            _checkout = checkout;
        }

        public object? CreditCard { get; set; }

        public void Cash(float balance)
        {
           
        }

        public void InsertCard(CreditCard creditCard)
        {
            CreditCard = creditCard;
        }

        public void RemoveCard()
        {
            CreditCard = null;
        }
        #endregion public methods
    }
}
