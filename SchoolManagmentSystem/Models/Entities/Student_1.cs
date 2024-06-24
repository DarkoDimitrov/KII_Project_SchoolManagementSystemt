namespace SchoolManagmentSystem.Models.Entities
{
    using System.Collections.Generic;

    public class Student
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<Subject>();
        }
    }

}
