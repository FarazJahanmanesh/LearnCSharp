namespace Domain.Entities;
#nullable disable
//disable props nullable


/*
 برای تعریف ساختار مدل های ما اسفتاده میشود
 */
public record User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; init; }
    // when we want to make object from user we can set value to the password
    public bool IsActive { get; private set; }

    public void Active()
        => IsActive = true;
    public void NotActive()
        => IsActive = false;
    //for boolean and enums is better to set the private set for prop and use methods 
}
