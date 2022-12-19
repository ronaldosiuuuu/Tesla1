using Tesla.Models;

namespace Tesla.Services
{
    public interface IBrugerService
    {
        bool IsUserAdmin { get; }
        string Username {get; }
        bool IsLoggedIn { get; }

        void SetUserLoggedIn(string name, bool isAdmin);

        public void TilføjBruger(LoggetInd nyBruger);
        public bool TjekLogInd(String username, string password);
        void UserLoggedOut();
    }
}
