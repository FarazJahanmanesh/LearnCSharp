using System;

namespace Domain.Entities;

//all way to write record
public record Person(string FirstName, string LastName);

//public record Car(string Make, string Model)
//{
//    public Car(string make, string model) => (Make, Model) = (make, model);
//}

public record Phone
{
    public string Make { get; set; }
    public string Model { get; set; }
    public Phone(string make, string model) => (Make, Model) = (make, model);
}
public record Employee : Person
{
    public string Department { get; init; }
    public Employee(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }
}