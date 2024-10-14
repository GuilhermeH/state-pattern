namespace StatePattern.Sample.Solution
{
    public interface IStatusDocument
    {
        void Edit(Document documento);
        void SendToReview(Document documento);
        void Approve(Document documento);
        void Reject(Document documento);
        void Cancel(Document documento);
    }
}
