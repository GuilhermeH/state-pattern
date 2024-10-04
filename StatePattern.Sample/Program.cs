using StatePattern.Sample;

Documento documento = new();

documento.Editar();

documento.EnviarParaRevisao();

// Tentar editar enquanto em revisão
documento.Editar();

// Aprovar o documento
documento.Aprovar();

// Tentar editar após aprovação
documento.Editar();

// Cancelar após aprovação (não permitido)
documento.Cancelar();