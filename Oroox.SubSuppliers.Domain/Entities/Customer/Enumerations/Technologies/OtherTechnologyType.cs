namespace Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies
{
    public enum OtherTechnologyType
    {
        DeepHoleDrilling,
        ThreadsM,
        ThreadsTr,
        Toothings,
        Engravings,
        LaserMarking,
        Knurling,
        Annealing,
        Other,
    }

    public class OtherTechnology : Entity
    {
        public OtherTechnologyType Type { get; set; }
    }
}
