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
    
    public partial class informacao_adicional
    {
        public informacao_adicional()
        {
            this.padrao_de_imposto_por_cfop = new HashSet<padrao_de_imposto_por_cfop>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_INFORMACAO_ADICIONAL { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual empresa empresa { get; set; }
        public virtual ICollection<padrao_de_imposto_por_cfop> padrao_de_imposto_por_cfop { get; set; }
    }
}