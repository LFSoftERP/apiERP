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
    
    public partial class pedido_faturamento
    {
        public pedido_faturamento()
        {
            this.fechamento_mercado_futuro = new HashSet<fechamento_mercado_futuro>();
            this.pedido_faturamento_parcelas = new HashSet<pedido_faturamento_parcelas>();
            this.pedido_faturamento_produto = new HashSet<pedido_faturamento_produto>();
            this.venda_prestacao_servico = new HashSet<venda_prestacao_servico>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_COOPERADO { get; set; }
        public Nullable<int> INT_ID_CLIENTE { get; set; }
        public Nullable<System.DateTime> DATE_AGENDAMENTO { get; set; }
        public bool BOOL_DOACAO { get; set; }
        public bool BOOL_PERMUTA { get; set; }
        public bool BOOL_ECOMMERCE { get; set; }
        public string TXT_OBS { get; set; }
        public string TXT_INFORMACOES_ADD { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public Nullable<int> INT_ID_FUNC_ULTIMA_EDICAO { get; set; }
        public Nullable<System.DateTime> DATE_ULTIMA_EDICAO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public Nullable<int> INT_ID_TALHAO { get; set; }
        public string TXT_MODALIDADE_FRETE { get; set; }
        public int INT_INDEX_MODALIDADE_FRETE { get; set; }
        public Nullable<int> INT_ID_MOTORISTA { get; set; }
        public string TXT_PLACA { get; set; }
        public string TXT_UF_PLACA { get; set; }
        public string TXT_ANTT { get; set; }
        public int INT_VOLUMES { get; set; }
        public decimal DECIMAL_PESO_LIQUIDO { get; set; }
        public decimal DECIMAL_PESO_BRUTO { get; set; }
        public int INT_ID_SETOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_NR_PEDIDO { get; set; }
        public string TXT_ESPECIE { get; set; }
        public bool BOOL_BARTER { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual ICollection<fechamento_mercado_futuro> fechamento_mercado_futuro { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual motorista motorista { get; set; }
        public virtual setor setor { get; set; }
        public virtual talhao talhao { get; set; }
        public virtual ICollection<pedido_faturamento_parcelas> pedido_faturamento_parcelas { get; set; }
        public virtual ICollection<pedido_faturamento_produto> pedido_faturamento_produto { get; set; }
        public virtual ICollection<venda_prestacao_servico> venda_prestacao_servico { get; set; }
    }
}
