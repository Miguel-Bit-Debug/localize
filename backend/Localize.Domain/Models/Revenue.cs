namespace Localize.Domain.Models
{
    public class Revenue
    {
        public Revenue(string cnpj,
                       string resultado)
        {
            Id = Guid.NewGuid();
            Cnpj = cnpj;
            Resultado = resultado;
        }

        public Guid Id { get; set; }
        public string Cnpj { get; private set; }
        public string Resultado { get; private set; }
    }
}
