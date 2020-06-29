namespace LearningCSharp.Hr
{
    public abstract class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        public abstract string GetInfo();
    }
}
