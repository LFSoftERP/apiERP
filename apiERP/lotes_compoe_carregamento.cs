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
    
    public partial class lotes_compoe_carregamento
    {
        public int INT_ID { get; set; }
        public int INT_ID_CADASTRO_ENTRADA { get; set; }
        public float FLOAT_QTD_SACAS { get; set; }
        public int INT_ID_CARREGAMENTO_PARA_TERCEIROS { get; set; }
        public bool BOOL_FLAG { get; set; }
    
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual carregamento_para_armazem_terceiros carregamento_para_armazem_terceiros { get; set; }
    }
}