using System.Collections.Generic;

namespace WishList.Core
{
    class WishList
    {
        public User Owner { get; set; }
        public IEnumerable<Wish> Wishes { get; set; }
    }
}
