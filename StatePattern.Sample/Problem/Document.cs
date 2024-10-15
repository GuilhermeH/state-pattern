namespace StatePattern.Sample.Problem
{
    public class Document
    {
        public EnumStatus Status { get; private set; }

        public Document()
        {
            Status = EnumStatus.Draft;
        }

        public void Edit()
        {
            if (Status == EnumStatus.Draft || Status == EnumStatus.Rejected)
            {
                Console.WriteLine("Document be in draft status.");
            }
            else
            {
                Console.WriteLine("It's not possible edit document in current status.");
            }
        }

        public void SendToReview()
        {
            if (Status == EnumStatus.Draft || Status == EnumStatus.Rejected)
            {
                Status = EnumStatus.Reviewed;
                Console.WriteLine("Document send to review");
            }
            else
            {
                Console.WriteLine("It's not possible send document to review in current status.");
            }
        }

        public void Approve()
        {
            if (Status == EnumStatus.Reviewed)
            {
                Status = EnumStatus.Approved;
                Console.WriteLine("Approved document");
            }
            else
            {
                Console.WriteLine("It's not possible approved document in current status.");
            }
        }

        public void Reject()
        {
            if (Status == EnumStatus.Reviewed)
            {
                Status = EnumStatus.Rejected;
                Console.WriteLine("Rejected document");
            }
            else
            {
                Console.WriteLine("It's not possible reject document in current status.");
            }
        }

        public void Cancel()
        {
            if (Status == EnumStatus.Draft || Status == EnumStatus.Reviewed || Status == EnumStatus.Rejected)
            {
                Status = EnumStatus.Canceled;
                Console.WriteLine("Canceled document");
            }
            else
            {
                Console.WriteLine("It's not possible cancel document in current status.");
            }
        }
    }
}
