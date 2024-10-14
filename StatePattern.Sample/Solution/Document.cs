using StatePattern.Sample.Solution.Status;

namespace StatePattern.Sample.Solution
{
    public class Document
    {
        public IStatusDocument Status;

        /// <summary>
        /// Initial state of document it's Draft
        /// </summary>
        public Document() => Status = new Draft();

        public void SetStatus(IStatusDocument novoEstado) => Status = novoEstado;

        public void Edit() => Status.Edit(this);

        public void SendToReview() => Status.SendToReview(this);

        public void Approve() => Status.Approve(this);

        public void Reject() => Status.Reject(this);

        public void Cancel() => Status.Cancel(this);

    }
}