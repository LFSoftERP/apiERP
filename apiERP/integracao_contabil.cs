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
    
    public partial class integracao_contabil
    {
        public integracao_contabil()
        {
            this.integracao_contabil_lancamentos = new HashSet<integracao_contabil_lancamentos>();
        }
    
        public int INT_ID { get; set; }
        public System.DateTime DATE_GEROU { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
        public Nullable<int> INT_ID_FUNCIONARIO_EXCLUIU { get; set; }
        public string TXT_MOTIVO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual ICollection<integracao_contabil_lancamentos> integracao_contabil_lancamentos { get; set; }
    }
}
