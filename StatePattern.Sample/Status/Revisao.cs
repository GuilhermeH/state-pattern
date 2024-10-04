namespace StatePattern.Sample.Status
{
    public class Revisao : IStatusDocumento
    {
        public void Editar(Documento documento)
        {
            Console.WriteLine("Documento em revisão não pode ser editado.");
        }

        public void EnviarParaRevisao(Documento documento)
        {
            Console.WriteLine("Documento já está em revisão.");
        }

        public void Aprovar(Documento documento)
        {
            Console.WriteLine("Documento aprovado.");
            documento.DefinirEstado(new Aprovado());
        }

        public void Rejeitar(Documento documento)
        {
            Console.WriteLine("Documento rejeitado.");
            documento.DefinirEstado(new Rejeitado());
        }

        public void Cancelar(Documento documento)
        {
            Console.WriteLine("Documento em revisão cancelado.");
            documento.DefinirEstado(new Cancelado());
        }
    }
}
