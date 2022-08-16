namespace Delegate_Assignments
{
    internal class Program
    {
        public delegate string UserName();
        public delegate bool Predicate(TClass t);
        static void Main(string[] args)
        {
            //  var likelyUsername = t.FirstName + "." + t.LastName;
            Delegate classwork = (TClass t) =>
            {
                if (t.UserName == "Perks")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }
    }

    class TClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
    }
}