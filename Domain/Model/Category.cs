namespace Domain.Model;

public class Category : BaseModel
{
    public string Name { get; set; }
    public Category(Guid id, string name)
        : base(id)
    {
        Name = name;
    }
}