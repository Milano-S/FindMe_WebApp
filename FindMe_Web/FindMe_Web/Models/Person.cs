namespace FindMe_Web.Models
{
    public class Person
    {

        public int Id { get; set; }
        public string MissingPersonName { get; set; }
        public string LastSeen { get; set; }
        public int DaysMissing { get; set; }
        public string MoreInfo { get; set; }

        public Person()
        {

        }
    }
}
