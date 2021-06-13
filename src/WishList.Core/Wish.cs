using System;

namespace WishList.Core
{
    class Wish
    {
        public Item Item { get; set; }
        public User Owner { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedTimeStamp { get; set; }

    }
}
