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
    
    public partial class plano_conversao
    {
        public int INT_ID { get; set; }
        public int INT_ID_TALHAO { get; set; }
        public System.DateTime DATA_INICIO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OBS { get; set; }
        public int INT_ID_CADASTRO { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DATE_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual talhao talhao { get; set; }
    }
}