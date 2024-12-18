namespace ChallangeApp
{
    public class User
    {
        private List<float> grades = new List<float>();

        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

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
