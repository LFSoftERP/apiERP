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
    
    public partial class liquidacao_contrato_de_cambio_relacao_nf
    {
        public int INT_ID { get; set; }
        public int INT_ID_ORIGEM_DO_PRODUTO_NOTA_FISCAL { get; set; }
        public int INT_ID_LIQUIDACAO { get; set; }
        public decimal DECIMAL_VALOR_EM_DOLAR { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual liquidacao_contrato_de_cambio liquidacao_contrato_de_cambio { get; set; }
        public virtual origem_do_produto_nota_fiscal origem_do_produto_nota_fiscal { get; set; }
    }
}