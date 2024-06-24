namespace SchoolManagmentSystem.Models.Entities
{
    using System;
    using System.Collections.Generic;

    public class Subject
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfWeeklyClasses { get; set; }
        public List<Literature> LiteratureUsed { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

       

        public Subject()
        {
            LiteratureUsed = new List<Literature>();
            Students = new List<Student>();
        }
    }

}
