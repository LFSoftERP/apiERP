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
    
    public partial class memorando_meios_circulacao
    {
        public int INT_ID { get; set; }
        public int INT_ID_CIRCULACAO { get; set; }
        public int INT_ID_MEMORANDO { get; set; }
        public string TXT_OBS { get; set; }
        public int INT_ID_CADASTROU { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_EXCLUIU { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUIU { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual meio_de_circulacao meio_de_circulacao { get; set; }
        public virtual memorando memorando { get; set; }
    }
}
