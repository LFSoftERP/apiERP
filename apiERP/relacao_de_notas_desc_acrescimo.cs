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
    
    public partial class relacao_de_notas_desc_acrescimo
    {
        public relacao_de_notas_desc_acrescimo()
        {
            this.relacao_notas_descontoacrescimo_lotes_fechamento = new HashSet<relacao_notas_descontoacrescimo_lotes_fechamento>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_DESC_ACRESCIMO { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public System.DateTime DATE_NF { get; set; }
        public int INT_NF_COMP { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public int INT_NF_CRED { get; set; }
        public bool BOOL_NF_COMPRA_COMPL { get; set; }
        public decimal DECIMAL_VALOR_CRED { get; set; }
        public decimal DECIMAL_VALOR_COMP { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual descontos_acrescimos_pg_cafe descontos_acrescimos_pg_cafe { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual ICollection<relacao_notas_descontoacrescimo_lotes_fechamento> relacao_notas_descontoacrescimo_lotes_fechamento { get; set; }
    }
}
