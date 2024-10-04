using StatePattern.Sample.Status;

namespace StatePattern.Sample
{
    public class Documento
    {
        public IStatusDocumento Status;

        /// <summary>
        /// Estado inicial do documento é do tipo Rascunho;
        /// </summary>
        public Documento() => Status = new Rascunho();
        
        public void DefinirEstado(IStatusDocumento novoEstado) => Status = novoEstado;

        public void Editar() => Status.Editar(this);

        public void EnviarParaRevisao() => Status.EnviarParaRevisao(this);

        public void Aprovar() => Status.Aprovar(this);

        public void Rejeitar() => Status.Rejeitar(this);

        public void Cancelar() => Status.Cancelar(this);

    }
}