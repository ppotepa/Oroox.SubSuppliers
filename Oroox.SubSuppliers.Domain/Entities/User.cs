namespace Oroox.SubSuppliers.Domain.Entities
{
    public class User : Entity
    {
        public virtual string Name { get; set; }
        public string EmailAddress { get; set; }

    }
}
