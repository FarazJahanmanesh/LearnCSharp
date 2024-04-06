using Domain.Entities;

User a = new User();
a.Name = "faraz";
a.Email = "farazebipax@gmail.com";
a.Password = "farazmj82";
a.Id = 1;



Console.WriteLine(a);
Console.WriteLine(a.GetType());

Console.WriteLine(a.Id);
Console.WriteLine(a.Name);
Console.WriteLine(a.Email);
Console.WriteLine(a.Password);