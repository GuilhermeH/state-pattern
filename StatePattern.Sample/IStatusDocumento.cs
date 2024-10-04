namespace StatePattern.Sample
{
    public interface IStatusDocumento
    {
        void Editar(Documento documento);
        void EnviarParaRevisao(Documento documento);
        void Aprovar(Documento documento);
        void Rejeitar(Documento documento);
        void Cancelar(Documento documento);
    }
}
