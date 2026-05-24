using System;

namespace ClassLibrary
{
    public class clsUsers
    {
        public bool Active { get; set; }
        public DateTime JoinedDate { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public bool UserEmailVerified { get; set; }
    }
}