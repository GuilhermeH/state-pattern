namespace StatePattern.Sample.Solution.Status
{
    public class Rejected : IStatusDocument
    {
        public void Edit(Document documento)
        {
            Console.WriteLine("Editing reject document.");
            documento.SetStatus(new Draft());
        }

        public void SendToReview(Document documento)
        {
            Console.WriteLine("Rejected document resent to review.");
            documento.SetStatus(new Reviewed());
        }

        public void Approve(Document documento)
        {
            Console.WriteLine("Reject document cannot be approve directily.");
        }

        public void Reject(Document documento)
        {
            Console.WriteLine("Documento alredy rejected.");
        }

        public void Cancel(Document documento)
        {
            Console.WriteLine("Document rejected was canceled");
            documento.SetStatus(new Canceled());
        }
    }
}
