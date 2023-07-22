using Newtonsoft.Json;

namespace Localize.Domain.Models
{
    public class CNPJ
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status">Example: OK</param>
        /// <param name="ultimaAtualizacao">Data da última atualização dos dados com a Receita Federal</param>
        /// <param name="cnpj">CNPJ da Empresa</param>
        /// <param name="tipo">Tipo da Empresa</param>
        /// <param name="porte">Porte da Empresa</param>
        /// <param name="nome">Razão Social</param>
        /// <param name="fantasia">Nome Fantasia</param>
        /// <param name="abertura">Data de Abertura</param>
        /// <param name="atividadePrincipal">Atividade Principal</param>
        /// <param name="atividadesSecundaria">Atividades Secundárias</param>
        /// <param name="naturezaJuridica">Natureza Jurídica</param>
        /// <param name="logradouro">Logradouro</param>
        /// <param name="numero">Número</param>
        /// <param name="complemento">Complemento</param>
        /// <param name="cep">CEP</param>
        /// <param name="bairro">Bairro</param>
        /// <param name="municipio">Município</param>
        /// <param name="uf">Estado</param>
        /// <param name="email">Email</param>
        /// <param name="telefone">Telefone</param>
        /// <param name="efr">Ente Federativo Responsável</param>
        /// <param name="situacao">Situação</param>
        /// <param name="dataSituacao">Data da Situação</param>
        /// <param name="motivoSituacao">Motivo da Situação</param>
        /// <param name="situacaoEspecial">Situação Especial</param>
        /// <param name="dataSituacaoEspecial">Data da Situação Especial</param>
        /// <param name="capitalSocial">Capital Social</param>
        /// <param name="qsa">Capital Social</param>
        /// <param name="billing">Informações sobre o uso de limites da consulta</param>
        public CNPJ(string status,
                    DateTime ultimaAtualizacao,
                    string cnpj,
                    string tipo,
                    string porte,
                    string nome,
                    string fantasia,
                    string abertura,
                    IEnumerable<AtividadePrincipal> atividadePrincipal,
                    IEnumerable<AtividadesSecundaria> atividadesSecundaria,
                    string naturezaJuridica,
                    string logradouro,
                    string numero,
                    string complemento,
                    string cep,
                    string bairro,
                    string municipio,
                    string uf,
                    string email,
                    string telefone,
                    string efr,
                    string situacao,
                    string dataSituacao,
                    string motivoSituacao,
                    string situacaoEspecial,
                    string dataSituacaoEspecial,
                    string capitalSocial,
                    IEnumerable<Qsa> qsa,
                    Billing billing)
        {
            Id = Guid.NewGuid();
            Status = status;
            UltimaAtualizacao = ultimaAtualizacao;
            Cnpj = cnpj;
            Tipo = tipo;
            Porte = porte;
            Nome = nome;
            Fantasia = fantasia;
            Abertura = abertura;
            AtividadePrincipal = atividadePrincipal;
            AtividadesSecundaria = atividadesSecundaria;
            NaturezaJuridica = naturezaJuridica;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Municipio = municipio;
            Uf = uf;
            Email = email;
            Telefone = telefone;
            Efr = efr;
            this.situacao = situacao;
            DataSituacao = dataSituacao;
            MotivoSituacao = motivoSituacao;
            SituacaoEspecial = situacaoEspecial;
            DataSituacaoEspecial = dataSituacaoEspecial;
            CapitalSocial = capitalSocial;
            Qsa = qsa;
            Billing = billing;
        }

        public Guid Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; private set; }
        [JsonProperty("ultima_atualizacao")]
        public DateTime UltimaAtualizacao { get; private set; }
        [JsonProperty("ultima_atualizacao")]
        public string Cnpj { get; private set; }
        [JsonProperty("tipo")]
        public string Tipo { get; private set; }
        [JsonProperty("porte")]
        public string Porte { get; private set; }
        [JsonProperty("nome")]
        public string Nome { get; private set; }
        [JsonProperty("fantasia")]
        public string Fantasia { get; private set; }
        [JsonProperty("abertura")]
        public string Abertura { get; private set; }
        [JsonProperty("atividade_principal")]
        public IEnumerable<AtividadePrincipal> AtividadePrincipal { get; private set; }
        [JsonProperty("atividades_secundarias")]
        public IEnumerable<AtividadesSecundaria> AtividadesSecundaria { get; private set; }
        [JsonProperty("natureza_juridica")]
        public string NaturezaJuridica { get; private set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; private set; }
        [JsonProperty("numero")]
        public string Numero { get; private set; }
        [JsonProperty("complemento")]
        public string Complemento { get; private set; }
        [JsonProperty("cep")]
        public string Cep { get; private set; }
        [JsonProperty("bairro")]
        public string Bairro { get; private set; }
        [JsonProperty("municipio")]
        public string Municipio { get; private set; }
        [JsonProperty("uf")]
        public string Uf { get; private set; }
        [JsonProperty("email")]
        public string Email { get; private set; }
        [JsonProperty("telefone")]
        public string Telefone { get; private set; }
        [JsonProperty("efr")]
        public string Efr { get; private set; }
        [JsonProperty("situacao")]
        public string situacao { get; private set; }
        [JsonProperty("data_situacao")]
        public string DataSituacao { get; private set; }
        [JsonProperty("motivo_situacao")]
        public string MotivoSituacao { get; private set; }
        [JsonProperty("situacao_especial")]
        public string SituacaoEspecial { get; private set; }
        [JsonProperty("data_situacao_especial")]
        public string DataSituacaoEspecial { get; private set; }
        [JsonProperty("capital_social")]
        public string CapitalSocial { get; private set; }
        [JsonProperty("qsa")]
        public IEnumerable<Qsa> Qsa { get; private set; }
        [JsonProperty("Billing")]
        public Billing Billing { get; private set; }
    }
}
