namespace SchoolManagmentSystem.Models.Entities
{
    using System.Collections.Generic;

    public class Teacher
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public List<Subject> Subjects { get; set; }

        public Teacher()
        {
            Subjects = new List<Subject>();
        }
    }
}

