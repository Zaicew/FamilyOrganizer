using System.Xml.Serialization;

namespace Domain.Model;

public class Category : BaseModel
{
    public Category(Guid id)
        : base(id)
    {

    }

    public Category()
    {

    }
}