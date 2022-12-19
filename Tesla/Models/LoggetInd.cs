namespace Tesla.Models
{
    public class LoggetInd
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }

        public LoggetInd():this("",false, "")
        {
        }

        public LoggetInd(string name, bool isAdmin, string password)
        {
           Name = name;
           IsAdmin = isAdmin;
            Password = password;
        }

        public override string ToString()
        {
            return $"{{ {nameof(Name)}={Name}, {nameof(IsAdmin)}={IsAdmin.ToString()}}}";
        }
    }
}
