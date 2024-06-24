namespace SchoolManagmentSystem.Models.Entities
{
    public abstract class Literature
    {
        public int Id { get; set; }  
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Subject Subject { get; set; }

    }

}
