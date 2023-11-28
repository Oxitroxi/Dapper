﻿using System.ComponentModel.DataAnnotations.Schema;


[Table("Person")]
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}
