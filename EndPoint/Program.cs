using Domain.Entities;

User a = new User()
{
    Password = "farazmj82"
};
a.Name = "faraz";
a.Email = "farazebipax@gmail.com";
a.Id = 1;
a.Active();

User b = a with { Password = "F@razmj82" };
b.NotActive();

//here we can have our user but change the password with 'with'
//its just for record

Console.WriteLine(a);
Console.WriteLine(a.GetType());

Console.WriteLine(a.Id);
Console.WriteLine(a.Name);
Console.WriteLine(a.Email);
Console.WriteLine(a.Password);