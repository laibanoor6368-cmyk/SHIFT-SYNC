using System;

namespace Shift_Sync.Models
{
    // C# class jo user table k column ko represent
    internal class User
    { public int UserID { get; set; }
        public string Username{ get; set; }
        public string Password { get; set; }
        public string Role{ get; set; }
    }
}
