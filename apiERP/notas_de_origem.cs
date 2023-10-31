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
    
    public partial class notas_de_origem
    {
        public notas_de_origem()
        {
            this.complementacoes_lote = new HashSet<complementacoes_lote>();
            this.contas_a_pagar_plano_de_contas = new HashSet<contas_a_pagar_plano_de_contas>();
            this.devolucao_de_compra = new HashSet<devolucao_de_compra>();
            this.lote_nota_cancelada = new HashSet<lote_nota_cancelada>();
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_LOTE { get; set; }
        public int INT_NF_RET { get; set; }
        public int INT_COMPRA { get; set; }
        public float FLOAT_QUANTIDAE { get; set; }
        public float FLOAT_VALOR_TOTAL { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public System.DateTime DATE_DATA_DA_NF { get; set; }
        public Nullable<int> INT_NF_CREDITO { get; set; }
        public Nullable<decimal> DECIMAL_VALOR_CREDITO { get; set; }
    
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual ICollection<complementacoes_lote> complementacoes_lote { get; set; }
        public virtual ICollection<contas_a_pagar_plano_de_contas> contas_a_pagar_plano_de_contas { get; set; }
        public virtual ICollection<devolucao_de_compra> devolucao_de_compra { get; set; }
        public virtual ICollection<lote_nota_cancelada> lote_nota_cancelada { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
    }
}
