namespace ResTIConnect.Domain.Common;
//tudo que for comum a todas as entidades, ou seja todas as entidades vao hedar de BaseEntity
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}


