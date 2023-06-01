﻿namespace Infra.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public string Description { get; set; }
    public DateTime PublicationDate { get; set; }
}
