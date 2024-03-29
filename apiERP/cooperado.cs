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
    
    public partial class cooperado
    {
        public cooperado()
        {
            this.agendamento_certificacao = new HashSet<agendamento_certificacao>();
            this.agendamento_cooperado = new HashSet<agendamento_cooperado>();
            this.amostra_da_roca = new HashSet<amostra_da_roca>();
            this.amostra_solo_foliar = new HashSet<amostra_solo_foliar>();
            this.autorizacao_dev_cooperado = new HashSet<autorizacao_dev_cooperado>();
            this.cadastro_entrada = new HashSet<cadastro_entrada>();
            this.complementacao = new HashSet<complementacao>();
            this.contas_a_pagar_e_receber = new HashSet<contas_a_pagar_e_receber>();
            this.convenio_titular = new HashSet<convenio_titular>();
            this.cooperado1 = new HashSet<cooperado>();
            this.dados_bancarios = new HashSet<dados_bancarios>();
            this.projeto_cooperado = new HashSet<projeto_cooperado>();
            this.cursos_cooperados = new HashSet<cursos_cooperados>();
            this.descontos_acrescimos_pg_cafe = new HashSet<descontos_acrescimos_pg_cafe>();
            this.emprestimos = new HashSet<emprestimos>();
            this.emprestimos1 = new HashSet<emprestimos>();
            this.emprestimos2 = new HashSet<emprestimos>();
            this.fechamento_mercado_futuro = new HashSet<fechamento_mercado_futuro>();
            this.cooperado_que_fazem_parte_do_mercado_futuro = new HashSet<cooperado_que_fazem_parte_do_mercado_futuro>();
            this.dap = new HashSet<dap>();
            this.email = new HashSet<email>();
            this.norma_cooperado = new HashSet<norma_cooperado>();
            this.propriedade = new HashSet<propriedade>();
            this.referencia_comercial = new HashSet<referencia_comercial>();
            this.telefone = new HashSet<telefone>();
            this.formulario_aplicar = new HashSet<formulario_aplicar>();
            this.historico_bloqueio_financeiro = new HashSet<historico_bloqueio_financeiro>();
            this.historico_de_alteracao_de_status = new HashSet<historico_de_alteracao_de_status>();
            this.lote_produto = new HashSet<lote_produto>();
            this.movimento_bancario = new HashSet<movimento_bancario>();
            this.notas_para_assinar = new HashSet<notas_para_assinar>();
            this.ordem_de_producao = new HashSet<ordem_de_producao>();
            this.pagamento_emprestimo = new HashSet<pagamento_emprestimo>();
            this.pedido_faturamento = new HashSet<pedido_faturamento>();
            this.pronaf = new HashSet<pronaf>();
            this.solicitacao_de_retirada = new HashSet<solicitacao_de_retirada>();
            this.venda_prestacao_servico = new HashSet<venda_prestacao_servico>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ADESAO { get; set; }
        public string TXT_NOME { get; set; }
        public string TXT_RG { get; set; }
        public string TXT_CPF_CNPJ { get; set; }
        public string TXT_TITULO_ELEITOR { get; set; }
        public Nullable<System.DateTime> DATE_NASCIMENTO { get; set; }
        public string TXT_FILIACAO_PATERNA { get; set; }
        public string TXT_FILIACAO_MATERNA { get; set; }
        public string CHAR_ESTADO_CIVIL { get; set; }
        public string TXT_NATURALIDADE { get; set; }
        public string TXT_NACIONALIDADE { get; set; }
        public string TXT_PROFISSAO { get; set; }
        public bool BOOL_PESSOA_JUR_FIS { get; set; }
        public string TXT_IM { get; set; }
        public string TXT_IE { get; set; }
        public string TXT_NOME_FANTASIA { get; set; }
        public Nullable<int> INT_ID_GRUPO_REUNIAO { get; set; }
        public string TXT_REPRESENTANTE_LEGAL { get; set; }
        public string CHAR_STATUS { get; set; }
        public string CHAR_SEXO { get; set; }
        public Nullable<System.DateTime> DATE_POSSE { get; set; }
        public Nullable<System.DateTime> DATE_INDICACAO { get; set; }
        public Nullable<System.DateTime> DATE_APROVACAO { get; set; }
        public string TXT_FOTO { get; set; }
        public Nullable<bool> BOOL_POSSUI_DAP { get; set; }
        public string TXT_CPF_CONJUGE { get; set; }
        public string TXT_RG_CONJUGE { get; set; }
        public string TXT_TITULO_ELEITOR_CONJUGE { get; set; }
        public string TXT_NOME_CONJUGE { get; set; }
        public Nullable<System.DateTime> DATE_NASC_CONJUGE { get; set; }
        public Nullable<bool> BOOL_POSSUI_SOCIO { get; set; }
        public string TXT_OBS_SOCIO { get; set; }
        public Nullable<bool> BOOL_POSSUI_PARCEIRO { get; set; }
        public string TXT_OBS_PARCEIRO { get; set; }
        public Nullable<bool> BOOL_CONTRATO_TEMP { get; set; }
        public Nullable<bool> BOOL_CONTRATO_FIXO { get; set; }
        public bool BOOL_TIPO_CULTIVO { get; set; }
        public Nullable<int> INT_QTD_CONT_FIXO { get; set; }
        public Nullable<int> INT_QTD_CONT_TEMP { get; set; }
        public bool BOOL_COOP_NAO_COOP { get; set; }
        public bool BOOL_RECADASTRO { get; set; }
        public string TXT_DESCRICAO_DOC_PENDENTE { get; set; }
        public bool BOOL_POSSUI_CONJUGE { get; set; }
        public Nullable<System.DateTime> DATE_INIT_COMERCIALIZAR { get; set; }
        public bool BOOL_FILHO_MENOR_18 { get; set; }
        public bool BOOL_FILHO_ESTUDA { get; set; }
        public decimal DECIMAL_QTD_FILHOS { get; set; }
        public Nullable<int> INT_ID_CONJUGE { get; set; }
        public Nullable<System.DateTime> DATE_FILIACAO { get; set; }
        public Nullable<bool> BOOL_FAMILIAR { get; set; }
        public Nullable<int> INT_ID_CONTA_CONTABIL { get; set; }
        public string TXT_RUA { get; set; }
        public string TXT_NR { get; set; }
        public string TXT_BAIRRO { get; set; }
        public string TXT_CEP { get; set; }
        public string TXT_COMPLEMENTO { get; set; }
        public string TXT_CIDADE { get; set; }
        public string TXT_UF { get; set; }
        public Nullable<int> INT_ID_CEP_ENDERECO { get; set; }
        public bool BOOL_CAFE_FEMININO { get; set; }
        public bool BOOL_LISTA_TRABALHO_ESCRAVO { get; set; }
        public bool BOOL_SOCIO_FUNDADOR { get; set; }
        public Nullable<System.DateTime> DATE_PRAZO_PERCA_BENEFICIOS { get; set; }
        public Nullable<System.DateTime> DATE_LANCAMENTO_DE_SUSPENSAO_BENEFICIOS { get; set; }
        public Nullable<int> INT_ID_QUEM_LANCOU_SUSPENSAO_BENEFICIOS { get; set; }
        public string TXT_FLO_ID { get; set; }
        public Nullable<decimal> DECIMAL_COTA { get; set; }
        public bool BOOL_PERU { get; set; }
        public bool BOOL_OLEIRICULTOR { get; set; }
        public string TXT_RFA_ID { get; set; }
        public string TXT_OBS_FILHO_MENOR_18 { get; set; }
        public Nullable<int> INT_ID_CADASTROU { get; set; }
        public Nullable<int> INT_ID_ALTEROU { get; set; }
        public Nullable<System.DateTime> DATE_CADASTRO { get; set; }
        public Nullable<System.DateTime> DATE_ALTEROU { get; set; }
        public bool BOOL_BLOQUEAR_FINANCEIRO { get; set; }
        public string TXT_MOTIVO_BLOQUEIO { get; set; }
    
        public virtual ICollection<agendamento_certificacao> agendamento_certificacao { get; set; }
        public virtual ICollection<agendamento_cooperado> agendamento_cooperado { get; set; }
        public virtual ICollection<amostra_da_roca> amostra_da_roca { get; set; }
        public virtual ICollection<amostra_solo_foliar> amostra_solo_foliar { get; set; }
        public virtual ICollection<autorizacao_dev_cooperado> autorizacao_dev_cooperado { get; set; }
        public virtual ICollection<cadastro_entrada> cadastro_entrada { get; set; }
        public virtual cepbr_enderecos cepbr_enderecos { get; set; }
        public virtual ICollection<complementacao> complementacao { get; set; }
        public virtual ICollection<contas_a_pagar_e_receber> contas_a_pagar_e_receber { get; set; }
        public virtual ICollection<convenio_titular> convenio_titular { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual plano_de_contas_contabil plano_de_contas_contabil { get; set; }
        public virtual ICollection<cooperado> cooperado1 { get; set; }
        public virtual cooperado cooperado2 { get; set; }
        public virtual grupo_reuniao grupo_reuniao { get; set; }
        public virtual ICollection<dados_bancarios> dados_bancarios { get; set; }
        public virtual ICollection<projeto_cooperado> projeto_cooperado { get; set; }
        public virtual ICollection<cursos_cooperados> cursos_cooperados { get; set; }
        public virtual ICollection<descontos_acrescimos_pg_cafe> descontos_acrescimos_pg_cafe { get; set; }
        public virtual ICollection<emprestimos> emprestimos { get; set; }
        public virtual ICollection<emprestimos> emprestimos1 { get; set; }
        public virtual ICollection<emprestimos> emprestimos2 { get; set; }
        public virtual ICollection<fechamento_mercado_futuro> fechamento_mercado_futuro { get; set; }
        public virtual ICollection<cooperado_que_fazem_parte_do_mercado_futuro> cooperado_que_fazem_parte_do_mercado_futuro { get; set; }
        public virtual ICollection<dap> dap { get; set; }
        public virtual ICollection<email> email { get; set; }
        public virtual ICollection<norma_cooperado> norma_cooperado { get; set; }
        public virtual ICollection<propriedade> propriedade { get; set; }
        public virtual ICollection<referencia_comercial> referencia_comercial { get; set; }
        public virtual ICollection<telefone> telefone { get; set; }
        public virtual ICollection<formulario_aplicar> formulario_aplicar { get; set; }
        public virtual ICollection<historico_bloqueio_financeiro> historico_bloqueio_financeiro { get; set; }
        public virtual ICollection<historico_de_alteracao_de_status> historico_de_alteracao_de_status { get; set; }
        public virtual ICollection<lote_produto> lote_produto { get; set; }
        public virtual ICollection<movimento_bancario> movimento_bancario { get; set; }
        public virtual ICollection<notas_para_assinar> notas_para_assinar { get; set; }
        public virtual ICollection<ordem_de_producao> ordem_de_producao { get; set; }
        public virtual ICollection<pagamento_emprestimo> pagamento_emprestimo { get; set; }
        public virtual ICollection<pedido_faturamento> pedido_faturamento { get; set; }
        public virtual ICollection<pronaf> pronaf { get; set; }
        public virtual ICollection<solicitacao_de_retirada> solicitacao_de_retirada { get; set; }
        public virtual ICollection<venda_prestacao_servico> venda_prestacao_servico { get; set; }
    }
}
