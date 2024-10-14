namespace StatePattern.Sample.Solution.Status
{
    public class Reviewed : IStatusDocument
    {
        public void Edit(Document documento)
        {
            Console.WriteLine("Document in review status, cannot be edited");
        }

        public void SendToReview(Document documento)
        {
            Console.WriteLine("Document alredy in review status.");
        }

        public void Approve(Document documento)
        {
            Console.WriteLine("Approved document.");
            documento.SetStatus(new Approved());
        }

        public void Reject(Document documento)
        {
            Console.WriteLine("Reject document.");
            documento.SetStatus(new Rejected());
        }

        public void Cancel(Document documento)
        {
            Console.WriteLine("Document in review status, was canceled.");
            documento.SetStatus(new Canceled());
        }
    }
}
