using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Shopping
{
    public class Cart : ShoppingBag
    {
        #region private attributes
        private bool _released = false;
        #endregion private attributes

        #region public methods

        public void Release()
        {
            _released = true;
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
