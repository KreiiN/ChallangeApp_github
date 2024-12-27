namespace ChallangeApp
{
    public class User
    {
        private List<float> grades = new List<float>();

        public User(string login)
        {
            this.Login = login;
        }
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; private set; }   
        public string Password { get; private set; }


        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
    }
}
