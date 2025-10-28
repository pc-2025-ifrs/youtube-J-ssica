namespace trabalho.Model
{
      public record class Usuario
      {

            public void AddInscricoes(string Nome)
            {
                  this.Inscricoes.Add(new Canal{
                        Id = Guid.NewGuid(),
                        Nome = Nome
                  });
            }
            public required Guid Id
            {
                  get; set;
            }
            public required string Nome
            {
                  get; set;
            }


            public List<Canal> Inscricoes
            {
                  get; set;
            } = [];
      }
}