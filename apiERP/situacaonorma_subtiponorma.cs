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
    
    public partial class situacaonorma_subtiponorma
    {
        public int INT_ID { get; set; }
        public int INT_ID_SUBTIPO { get; set; }
        public int INT_ID_SITUACAONORMA { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual situacao_norma situacao_norma { get; set; }
        public virtual subtipo_norma subtipo_norma { get; set; }
    }
}
