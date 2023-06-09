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
    
    public partial class pronaf
    {
        public pronaf()
        {
            this.pronaf_parcelas = new HashSet<pronaf_parcelas>();
            this.pronaf_pronaf_tipo = new HashSet<pronaf_pronaf_tipo>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
        public Nullable<int> INT_ID_EXCLUIU { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int INT_ID_FUNCIONARIO_LANCAMENTO { get; set; }
        public int INT_ID_COOPERADO { get; set; }
        public string TXT_NUMERO_CONTRATO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public Nullable<System.DateTime> DATE_ULTIMA_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_FUNCIONARIO_ALTERACAO { get; set; }
        public int INT_ID_FORMA_PAGAMENTO { get; set; }
        public System.DateTime DATE_DATA_FINANCIAMENTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OBSERVACAO { get; set; }
        public bool BOOL_CUSTEIO_INVESTIMENTO { get; set; }
    
        public virtual cooperado cooperado { get; set; }
        public virtual forma_de_pagamento forma_de_pagamento { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual ICollection<pronaf_parcelas> pronaf_parcelas { get; set; }
        public virtual ICollection<pronaf_pronaf_tipo> pronaf_pronaf_tipo { get; set; }
    }
}
