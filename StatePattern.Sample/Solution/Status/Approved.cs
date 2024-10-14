namespace StatePattern.Sample.Solution.Status
{
    public class Approved : IStatusDocument
    {
        public void Edit(Document documento)
        {
            Console.WriteLine("Approved document cannot be edited");
        }

        public void SendToReview(Document documento)
        {
            Console.WriteLine("Approved document cannot be send to review.");
        }

        public void Approve(Document documento)
        {
            Console.WriteLine("Document alredy approved");
        }

        public void Reject(Document documento)
        {
            Console.WriteLine("Approved document cannot be rejected.");
        }

        public void Cancel(Document documento)
        {
            Console.WriteLine("Approved documento cannot be canceled.");
        }
    }
}
