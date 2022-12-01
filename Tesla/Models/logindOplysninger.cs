namespace Tesla.Models
{
    public class logindOplysninger
    {
        public string userName { get; set; }
        public string passWord { get; set; }

        public logindOplysninger()
        {

        }

        public logindOplysninger(string username, string password)
        {
           passWord = password;
           userName = username;
        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
