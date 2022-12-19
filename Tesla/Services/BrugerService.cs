using Tesla.Models;

namespace Tesla.Services
{
    public class BrugerService: IBrugerService
    {
    public static bool iAmAdmin = false;
        private LoggetInd _user;

        public BrugerService()
        {
            _user = new LoggetInd();
            _brugere.Add(new LoggetInd("Admin", true, "admin123"));
        }

      
       
        public void SetUserLoggedIn(String name, bool isAdmin)
        {
            _user.Name = name;
            _user.IsAdmin = isAdmin;
            iAmAdmin = isAdmin;
        }

        public void UserLoggedOut()
        {
            _user.Name = "";
            _user.IsAdmin = false;
            iAmAdmin = false;
        }
        public bool IsLoggedIn
        {
            get
            {
                return !string.IsNullOrEmpty(_user.Name);
            }
        }

        public bool IsUserAdmin
        {
            get
            {
                return _user.IsAdmin;
            }
        }
        
        public String Username
        {
            get
            {
                return _user.Name;
            }
        }

        private List<LoggetInd> _brugere = new List<LoggetInd>();
        public void TilføjBruger(LoggetInd nyBruger)
        {
            _brugere.Add(nyBruger);
        }

        public bool TjekLogInd(String username, string password)
        {
            foreach (LoggetInd b in _brugere)
                if (b.Name == username && b.Password == password)
                {
                    SetUserLoggedIn(b.Name, b.IsAdmin);
                    return true;
                }
                    return false;
        }

        
    }
}
