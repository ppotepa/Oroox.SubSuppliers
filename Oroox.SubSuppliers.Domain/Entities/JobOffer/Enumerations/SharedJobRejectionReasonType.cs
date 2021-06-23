namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum SharedJobRejectionReasonTypeEnum
    {
        NoCapacity,
        MaterialNotAvailable,
        LeadTimeTooShort,
        NotFeasible
    }
    
    public class SharedJobRejectionReasonType : EnumerationEntity<SharedJobRejectionReasonTypeEnum>
    {
    }
}
