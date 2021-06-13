using System;

namespace WishList.Core
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
