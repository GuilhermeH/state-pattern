As seguinter ações são possíveis para um Documento:
Editar, Enviar para revisão, Aprovar, Rejeitar, e Cancelar.

As ações são definidas como métodos na interface IStatusDocumento.

Para cada ação possível existe uma implementação especializada que implementa a interface IStatusDocumento. 

Cada classe de especialista implementa a lógica de como as operações devem ser tratadas em cada status,

Exemplo dentro de Program.cs:
Quando tenta editar ou cancelar um documento no status Revisao ou Aprovado, a implementação lança uma mensagem de erro.


Regras sugeridas:
- Rascunho: Pode ser editado, enviado para revisão ou cancelado.
- Em Revisão: Não pode ser editado, pode ser aprovado, rejeitado ou cancelado.
- Aprovado: Não pode ser editado, cancelado, ou enviado para revisão novamente.
- Rejeitado: Pode ser editado e reenviado para revisão ou cancelado.
- Cancelado: Não pode mais ser alterado.
