namespace StatePattern.Sample.Status
{
    public class Rascunho : IStatusDocumento
    {
        public void Editar(Documento documento)
        {
            Console.WriteLine("Documento sendo editado.");
        }

        public void EnviarParaRevisao(Documento documento)
        {
            Console.WriteLine("Documento enviado para revisão.");
            documento.DefinirEstado(new Revisao());
        }

        public void Aprovar(Documento documento)
        {
            Console.WriteLine("Documento em rascunho não pode ser aprovado.");
        }

        public void Rejeitar(Documento documento)
        {
            Console.WriteLine("Documento em rascunho não pode ser rejeitado.");
        }

        public void Cancelar(Documento documento)
        {
            Console.WriteLine("Documento cancelado.");
            documento.DefinirEstado(new Cancelado());
        }
    }
}
