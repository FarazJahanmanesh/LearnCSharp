﻿using Domain.Entities;


//وقتی میگوییم رکورد قابل تغییر نیست منظور همچین چیزی است
var personRecord = new Person("faraz", "jahanmanesh");
//personRecord.Name = "far"; //this code have error

User a = new User()
{
    Password = "farazmj82"
};
a.Name = "faraz";
a.Email = "farazebipax@gmail.com";
a.Id = 1;
a.Active();

a.Name = "fa";

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

//how can use struct
Product cellphone;
cellphone.Name = "Iphone";
cellphone.Id = 2;
cellphone.Price = "2000";
cellphone.IsExist = true;

Console.WriteLine(cellphone);
Console.WriteLine(cellphone.GetType());

Console.WriteLine(cellphone.Id);
Console.WriteLine(cellphone.Name);
Console.WriteLine(cellphone.Price);
Console.WriteLine(cellphone.IsExist);






