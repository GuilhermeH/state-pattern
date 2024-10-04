namespace StatePattern.Sample.Status
{
    public class Rejeitado : IStatusDocumento
    {
        public void Editar(Documento documento)
        {
            Console.WriteLine("Editando documento rejeitado.");
            documento.DefinirEstado(new Rascunho());
        }

        public void EnviarParaRevisao(Documento documento)
        {
            Console.WriteLine("Documento rejeitado reenviado para revisão.");
            documento.DefinirEstado(new Revisao());
        }

        public void Aprovar(Documento documento)
        {
            Console.WriteLine("Documento rejeitado não pode ser aprovado diretamente.");
        }

        public void Rejeitar(Documento documento)
        {
            Console.WriteLine("Documento já foi rejeitado.");
        }

        public void Cancelar(Documento documento)
        {
            Console.WriteLine("Documento rejeitado cancelado.");
            documento.DefinirEstado(new Cancelado());
        }
    }
}
