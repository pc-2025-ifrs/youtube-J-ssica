namespace trabalho.Model
{
      public record class Video
      {


            public void Curtir()
            {
                  this.Curtidas++;
            }
            public void Descurtir()
            {
                  this.Descurtidas++;
            }

            public required Guid Id
            {
                  get; set;
            }
            public required string Nome
            {
                  get; set;
            }

            public string Descricao
            {
                  get; set;
            } = "";

            public required Canal Canal
            {
                  get; set;
            }

            public int Curtidas
            {
                  get; set;
            } = 0;

            public int Descurtidas
            {
                  get; set;
            } = 0;
            

      }
}