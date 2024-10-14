using StatePattern.Sample.Solution;

Document documento = new();

documento.Edit();

documento.SendToReview();

// Tentar editar enquanto em revisão
documento.Edit();

// Aprovar o documento
documento.Approve();

// Tentar editar após aprovação
documento.Edit();

// Cancelar após aprovação (não permitido)
documento.Cancel();