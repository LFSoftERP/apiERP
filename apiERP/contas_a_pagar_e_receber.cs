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
    
    public partial class contas_a_pagar_e_receber
    {
        public contas_a_pagar_e_receber()
        {
            this.contas_a_pagar_despesas_contrato = new HashSet<contas_a_pagar_despesas_contrato>();
            this.contas_a_pagar_e_receber1 = new HashSet<contas_a_pagar_e_receber>();
            this.contas_a_pagar_planejamento = new HashSet<contas_a_pagar_planejamento>();
            this.contas_a_pagar_plano_de_contas = new HashSet<contas_a_pagar_plano_de_contas>();
            this.despesas_realizadas_contas_a_pg_e_rec = new HashSet<despesas_realizadas_contas_a_pg_e_rec>();
            this.fluxo_de_caixa = new HashSet<fluxo_de_caixa>();
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_FORNECEDOR { get; set; }
        public int INT_ID_TIPO_DOCUMENTO { get; set; }
        public int INT_ID_TIPO_PAGAMENTO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public string TXT_NUMERO_DOCUMENTO { get; set; }
        public System.DateTime DATE_DOC { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_ID_MOVIMENTO { get; set; }
        public bool BOOL_ADIANTAMENTO { get; set; }
        public decimal DECIMAL_VALOR_ABATIDO_DO_ADIANTAMENTO { get; set; }
        public Nullable<bool> BOOL_ATO_COOPERADO_NAO_COOPERADO { get; set; }
        public System.DateTime DATA_RECEBIMENTO_DO_DOCUMENTO { get; set; }
        public Nullable<int> INT_ID_VINCULO_DE_ORIGEM_ENCARGO_CONTAS_A_PAGAR { get; set; }
        public Nullable<int> INT_ID_VINCULO_DE_ORIGEM_ENCARGO_NOTAS { get; set; }
        public Nullable<int> INT_ID_COOPERADO { get; set; }
        public bool BOOL_CONTAS_A_RECEBER { get; set; }
        public bool BOOL_REEMBOLSO { get; set; }
        public Nullable<int> INT_ID_PROCEDIMENTO { get; set; }
        public string TXT_CHAVE_DE_ACESSO { get; set; }
        public Nullable<int> INT_ID_COTACAO_COMPRA { get; set; }
        public bool BOOL_DEVOLUCAO_COTA { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual ICollection<contas_a_pagar_despesas_contrato> contas_a_pagar_despesas_contrato { get; set; }
        public virtual ICollection<contas_a_pagar_e_receber> contas_a_pagar_e_receber1 { get; set; }
        public virtual contas_a_pagar_e_receber contas_a_pagar_e_receber2 { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual movimento_bancario movimento_bancario { get; set; }
        public virtual nota_fiscal nota_fiscal { get; set; }
        public virtual procedimento procedimento { get; set; }
        public virtual cotacao_compra cotacao_compra { get; set; }
        public virtual tipo_de_documento tipo_de_documento { get; set; }
        public virtual tipo_de_pagamento tipo_de_pagamento { get; set; }
        public virtual ICollection<contas_a_pagar_planejamento> contas_a_pagar_planejamento { get; set; }
        public virtual ICollection<contas_a_pagar_plano_de_contas> contas_a_pagar_plano_de_contas { get; set; }
        public virtual ICollection<despesas_realizadas_contas_a_pg_e_rec> despesas_realizadas_contas_a_pg_e_rec { get; set; }
        public virtual ICollection<fluxo_de_caixa> fluxo_de_caixa { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
    }
}