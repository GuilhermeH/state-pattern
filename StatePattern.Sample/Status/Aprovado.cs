namespace StatePattern.Sample.Status
{
    public class Aprovado : IStatusDocumento
    {
        public void Editar(Documento documento)
        {
            Console.WriteLine("Documento aprovado não pode ser editado.");
        }

        public void EnviarParaRevisao(Documento documento)
        {
            Console.WriteLine("Documento aprovado não pode ser enviado para revisão.");
        }

        public void Aprovar(Documento documento)
        {
            Console.WriteLine("Documento já está aprovado.");
        }

        public void Rejeitar(Documento documento)
        {
            Console.WriteLine("Documento aprovado não pode ser rejeitado.");
        }

        public void Cancelar(Documento documento)
        {
            Console.WriteLine("Documento aprovado não pode ser cancelado.");
        }
    }
}
