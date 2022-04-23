namespace Restaurant_reviewModels
{
    public class Restaurant
    {
        public string Name { get; set; }
        private int _id;
        public int Id 
        { 
            get { 
                return _id;
            } 
            set
            {
                if (_id > value)
                    _id = value;
                else
                    throw new Exception("You cannot set Id lowwr that 0!");
            } 
        }

    }
}