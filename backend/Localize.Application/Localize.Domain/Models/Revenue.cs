using Newtonsoft.Json;

namespace Localize.Domain.Models
{
    public class Revenue
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
        public Revenue(string status,
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
        public string Status { get; private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public string Cnpj { get; private set; }
        public string Tipo { get; private set; }
        public string Porte { get; private set; }
        public string Nome { get; private set; }
        public string Fantasia { get; private set; }
        public string Abertura { get; private set; }
        public IEnumerable<AtividadePrincipal> AtividadePrincipal { get; private set; }
        public IEnumerable<AtividadesSecundaria> AtividadesSecundaria { get; private set; }
        public string NaturezaJuridica { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Uf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Efr { get; private set; }
        public string situacao { get; private set; }
        public string DataSituacao { get; private set; }
        public string MotivoSituacao { get; private set; }
        public string SituacaoEspecial { get; private set; }
        public string DataSituacaoEspecial { get; private set; }
        public string CapitalSocial { get; private set; }
        public IEnumerable<Qsa> Qsa { get; private set; }
        public Billing Billing { get; private set; }
    }
}
