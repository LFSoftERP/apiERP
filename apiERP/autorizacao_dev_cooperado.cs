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
    
    public partial class autorizacao_dev_cooperado
    {
        public autorizacao_dev_cooperado()
        {
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_AUTORIZACAO_GENERICA { get; set; }
        public int INT_NF { get; set; }
        public int INT_ID_COOPERADO { get; set; }
    
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual autorizacao_generica autorizacao_generica { get; set; }
        public virtual cooperado cooperado { get; set; }
    }
}