using StatePattern.Sample.Solution;

namespace StatePattern.Sample.Solution.Status
{
    public class Canceled : IStatusDocument
    {
        public void Edit(Document documento)
        {
            Console.WriteLine("Canceled document cannot be Edited.");
        }

        public void SendToReview(Document documento)
        {
            Console.WriteLine("Canceled document cannot be send to review.");
        }

        public void Approve(Document documento)
        {
            Console.WriteLine("Canceled document cannot be approved.");
        }

        public void Reject(Document documento)
        {
            Console.WriteLine("Canceled document cannot be rejected.");
        }

        public void Cancel(Document documento)
        {
            Console.WriteLine("Document alredy canceled.");
        }
    }
}
