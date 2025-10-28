// using System.Runtime.CompilerServices;

namespace trabalho.Model
{
      public record class Canal
      {

            public void AddVideos(Video videos)
            {
                  this.Videos.Add(videos);
            }
            public void AddInscritos(Usuario inscritos)
            {
                  this.Inscritos.Add(inscritos);
            }
            public Guid Id
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

            public List<Video> Videos
            {
                  get; set;
            } = [];

            public List<Usuario> Inscritos
            {
                  get; set;
            } = [];


      }
}