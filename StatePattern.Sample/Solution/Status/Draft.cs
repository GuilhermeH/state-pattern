namespace StatePattern.Sample.Solution.Status
{
    public class Draft : IStatusDocument
    {
        public void Edit(Document documento)
        {
            Console.WriteLine("Document be in draft status");
        }

        public void SendToReview(Document documento)
        {
            Console.WriteLine("Document send to review.");
            documento.SetStatus(new Reviewed());
        }

        public void Approve(Document documento)
        {
            Console.WriteLine("Document in draft status cannot be approved.");
        }

        public void Reject(Document documento)
        {
            Console.WriteLine("Document in draft status cannot be rejected.");
        }

        public void Cancel(Document documento)
        {
            Console.WriteLine("Document canceled.");
            documento.SetStatus(new Canceled());
        }
    }
}
