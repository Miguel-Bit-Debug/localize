using Newtonsoft.Json;

namespace Localize.Domain.Models
{
    public class Qsa
    {
        public Qsa(string nome,
                   string qual,
                   string paisOrigem,
                   string nomeRepLegal,
                   string qualRepLegal)
        {
            Nome = nome;
            Qual = qual;
            PaisOrigem = paisOrigem;
            NomeRepLegal = nomeRepLegal;
            QualRepLegal = qualRepLegal;
        }

        [JsonProperty("nome")]
        public string Nome { get; private set; }
        [JsonProperty("qual")]
        public string Qual { get; private set; }
        [JsonProperty("pais_origem")]
        public string PaisOrigem { get; private set; }
        [JsonProperty("nome_rep_legal")]
        public string NomeRepLegal { get; private set; }
        [JsonProperty("qual_rep_legal")]
        public string QualRepLegal { get; private set; }
    }
}
