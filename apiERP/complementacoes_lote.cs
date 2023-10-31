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
    
    public partial class complementacoes_lote
    {
        public complementacoes_lote()
        {
            this.contas_a_pagar_plano_de_contas = new HashSet<contas_a_pagar_plano_de_contas>();
            this.devolucao_de_compra = new HashSet<devolucao_de_compra>();
            this.lote_nota_cancelada = new HashSet<lote_nota_cancelada>();
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
            this.recibo_lotes = new HashSet<recibo_lotes>();
            this.relacao_notas_descontoacrescimo_lotes_fechamento = new HashSet<relacao_notas_descontoacrescimo_lotes_fechamento>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_PEDIDO_COMPRA { get; set; }
        public Nullable<int> INT_ID_NOTA_ORIGEM { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public int INT_ID_COMPLEMENTACAO { get; set; }
        public System.DateTime DATE { get; set; }
        public string TXT_FLAG_TIPO { get; set; }
        public bool BOOL_PROPORCIONAL_PESO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_NF_COMP { get; set; }
        public Nullable<int> INT_NF_CREDITO { get; set; }
        public decimal DECIMAL_VALOR_COMP { get; set; }
        public decimal DECIMAL_VALOR_CREDITO { get; set; }
        public int INT_ID_LOTE { get; set; }
        public Nullable<System.DateTime> DATE_NFE { get; set; }
        public decimal DECIMAL_QTD_SACAS { get; set; }
    
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual complementacao complementacao { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual lotes_do_fechamento_e_hedge lotes_do_fechamento_e_hedge { get; set; }
        public virtual notas_de_origem notas_de_origem { get; set; }
        public virtual ICollection<contas_a_pagar_plano_de_contas> contas_a_pagar_plano_de_contas { get; set; }
        public virtual ICollection<devolucao_de_compra> devolucao_de_compra { get; set; }
        public virtual ICollection<lote_nota_cancelada> lote_nota_cancelada { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual ICollection<recibo_lotes> recibo_lotes { get; set; }
        public virtual ICollection<relacao_notas_descontoacrescimo_lotes_fechamento> relacao_notas_descontoacrescimo_lotes_fechamento { get; set; }
    }
}
