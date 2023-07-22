using Newtonsoft.Json;

namespace Localize.Domain.Models
{
    public class AtividadesSecundaria
    {
        public AtividadesSecundaria(string code,
                                    string text)
        {
            Code = code;
            Text = text;
        }

        [JsonProperty("code")]
        public string Code { get; private set; }
        [JsonProperty("text")]
        public string Text { get; private set; }
    }
}
