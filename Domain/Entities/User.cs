namespace Domain.Entities;

public record User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; init; }
    // when we want to make object from user we can set value to the password
}
