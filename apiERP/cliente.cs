//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiERP
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        public cliente()
        {
            this.autorizacao_generica = new HashSet<autorizacao_generica>();
            this.cliente_conta_bancaria = new HashSet<cliente_conta_bancaria>();
            this.composicao_amostra_envio = new HashSet<composicao_amostra_envio>();
            this.email_cliente = new HashSet<email_cliente>();
            this.instrucao_preparo = new HashSet<instrucao_preparo>();
            this.telefone_cliente = new HashSet<telefone_cliente>();
            this.composicao_amostra = new HashSet<composicao_amostra>();
            this.comercial_ativo = new HashSet<comercial_ativo>();
            this.contas_a_pagar_e_receber = new HashSet<contas_a_pagar_e_receber>();
            this.convenio_plano_de_saude = new HashSet<convenio_plano_de_saude>();
            this.cotacao_compra = new HashSet<cotacao_compra>();
            this.cotacao_item_fornecedor = new HashSet<cotacao_item_fornecedor>();
            this.contrato = new HashSet<contrato>();
            this.historico_bloqueio_financeiro = new HashSet<historico_bloqueio_financeiro>();
            this.lote_produto = new HashSet<lote_produto>();
            this.movimento_bancario = new HashSet<movimento_bancario>();
            this.ordem_de_producao = new HashSet<ordem_de_producao>();
            this.ordem_servico_celular = new HashSet<ordem_servico_celular>();
            this.pedido_faturamento = new HashSet<pedido_faturamento>();
            this.planejamento_acoes_do_item_participantes = new HashSet<planejamento_acoes_do_item_participantes>();
            this.portifolio_fornecedor = new HashSet<portifolio_fornecedor>();
            this.procedimento = new HashSet<procedimento>();
            this.procedimento1 = new HashSet<procedimento>();
            this.produtos_ccontabeis_referencia_terceiros = new HashSet<produtos_ccontabeis_referencia_terceiros>();
            this.projetos_da_empresa = new HashSet<projetos_da_empresa>();
            this.projetos_realizados = new HashSet<projetos_realizados>();
            this.solicitacao_de_retirada = new HashSet<solicitacao_de_retirada>();
            this.venda_prestacao_servico = new HashSet<venda_prestacao_servico>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_NOME { get; set; }
        public string TXT_PAIS { get; set; }
        public string TXT_RUA { get; set; }
        public string TXT_BAIRRO { get; set; }
        public string TXT_NUM { get; set; }
        public string TXT_COMPLEMENTO { get; set; }
        public string TXT_CEP { get; set; }
        public string TXT_IM { get; set; }
        public string TXT_IE { get; set; }
        public bool BOOL_PESSOA_FIS_JURIDICA { get; set; }
        public string TXT_CPF_CNPJ { get; set; }
        public string TXT_NOME_FANTASIA { get; set; }
        public string TXT_CIDADE { get; set; }
        public string TXT_UF { get; set; }
        public bool BOOL_FLAG { get; set; }
        public Nullable<int> INT_FLO_ID { get; set; }
        public Nullable<int> INT_ID_CEP_ENDERECO { get; set; }
        public Nullable<int> INT_ID_GRUPO_SERVICO { get; set; }
        public string TXT_PESSOA_DE_CONTATO { get; set; }
        public bool BOOL_CLIENTE { get; set; }
        public string TXT_INDICADOR_IE { get; set; }
        public bool BOOL_FORNECEDOR { get; set; }
        public Nullable<int> INT_ID_CODIGO_CONTABIL { get; set; }
        public bool BOOL_MEDICO { get; set; }
        public bool BOOL_BLOQUEAR_VENDAS { get; set; }
        public decimal DECIMAL_LIMITE_CREDITO { get; set; }
        public bool BOOL_IGNORAR_LIMITE_DE_CREDITO { get; set; }
        public string TXT_MOTIVO_BLOQUEIO { get; set; }
        public string TXT_REFERENCIA_1 { get; set; }
        public string TXT_CONTATO_1 { get; set; }
        public string TXT_REFERENCIA_2 { get; set; }
        public string TXT_CONTATO_2 { get; set; }
        public string TXT_CONTATO_3 { get; set; }
        public string TXT_REFERENCIA_3 { get; set; }
        public string TXT_ID_RFA { get; set; }
        public string TXT_FTUSA_ID { get; set; }
    
        public virtual ICollection<autorizacao_generica> autorizacao_generica { get; set; }
        public virtual cepbr_enderecos cepbr_enderecos { get; set; }
        public virtual ICollection<cliente_conta_bancaria> cliente_conta_bancaria { get; set; }
        public virtual ICollection<composicao_amostra_envio> composicao_amostra_envio { get; set; }
        public virtual ICollection<email_cliente> email_cliente { get; set; }
        public virtual grupo_de_servico grupo_de_servico { get; set; }
        public virtual ICollection<instrucao_preparo> instrucao_preparo { get; set; }
        public virtual plano_de_contas_contabil plano_de_contas_contabil { get; set; }
        public virtual ICollection<telefone_cliente> telefone_cliente { get; set; }
        public virtual ICollection<composicao_amostra> composicao_amostra { get; set; }
        public virtual ICollection<comercial_ativo> comercial_ativo { get; set; }
        public virtual ICollection<contas_a_pagar_e_receber> contas_a_pagar_e_receber { get; set; }
        public virtual ICollection<convenio_plano_de_saude> convenio_plano_de_saude { get; set; }
        public virtual ICollection<cotacao_compra> cotacao_compra { get; set; }
        public virtual ICollection<cotacao_item_fornecedor> cotacao_item_fornecedor { get; set; }
        public virtual ICollection<contrato> contrato { get; set; }
        public virtual ICollection<historico_bloqueio_financeiro> historico_bloqueio_financeiro { get; set; }
        public virtual ICollection<lote_produto> lote_produto { get; set; }
        public virtual ICollection<movimento_bancario> movimento_bancario { get; set; }
        public virtual ICollection<ordem_de_producao> ordem_de_producao { get; set; }
        public virtual ICollection<ordem_servico_celular> ordem_servico_celular { get; set; }
        public virtual ICollection<pedido_faturamento> pedido_faturamento { get; set; }
        public virtual ICollection<planejamento_acoes_do_item_participantes> planejamento_acoes_do_item_participantes { get; set; }
        public virtual ICollection<portifolio_fornecedor> portifolio_fornecedor { get; set; }
        public virtual ICollection<procedimento> procedimento { get; set; }
        public virtual ICollection<procedimento> procedimento1 { get; set; }
        public virtual ICollection<produtos_ccontabeis_referencia_terceiros> produtos_ccontabeis_referencia_terceiros { get; set; }
        public virtual ICollection<projetos_da_empresa> projetos_da_empresa { get; set; }
        public virtual ICollection<projetos_realizados> projetos_realizados { get; set; }
        public virtual ICollection<solicitacao_de_retirada> solicitacao_de_retirada { get; set; }
        public virtual ICollection<venda_prestacao_servico> venda_prestacao_servico { get; set; }
    }
}
