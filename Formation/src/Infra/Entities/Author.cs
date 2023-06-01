﻿namespace Infra.Entities
{
    public class Author : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; }
    }
}
