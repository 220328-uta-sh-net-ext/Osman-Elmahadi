namespace Restaurant_reviewDL
{
    
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string PassWord { get; }

        public Users()
        {
            FirstName = " ";
            LastName = "";
            PassWord = "";

        }
        public Users(string firstName, string lastName, string passWord)
        {
            FirstName = firstName;
            LastName = lastName;
            PassWord = passWord;
        }

    }
}