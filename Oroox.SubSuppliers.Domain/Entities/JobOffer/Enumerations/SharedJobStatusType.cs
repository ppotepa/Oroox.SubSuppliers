namespace Oroox.SubSuppliers.Domain.Entities
{
    public enum SharedJobStatusTypeEnum
    {
        NoAction,
        Accepted,
        Rejected,
        UnansweredQuestions,
    }
    public class SharedJobStatusType : EnumerationEntity<SharedJobStatusTypeEnum>
    {
    }
}
