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
    
    public partial class lote_resultado_rebeneficio_situacao_norma
    {
        public int INT_ID { get; set; }
        public int INT_ID_LOTE_RESULT_REBENEFICIO { get; set; }
        public int INT_ID_SITUACAO_NORMA { get; set; }
        public bool BOOL_FLAG_ATIVO_EXCLUIDO { get; set; }
    
        public virtual lote_resultado_rebeneficio lote_resultado_rebeneficio { get; set; }
        public virtual situacao_norma situacao_norma { get; set; }
    }
}