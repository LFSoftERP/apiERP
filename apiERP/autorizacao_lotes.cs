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
    
    public partial class autorizacao_lotes
    {
        public autorizacao_lotes()
        {
            this.lote_produto = new HashSet<lote_produto>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_AUTORIZACAO_GENERICA { get; set; }
        public decimal FLOAT_QTD_SACAS { get; set; }
        public string CHAR_TIPO_AUTORIZACAO { get; set; }
        public string CHAR_FLAG_LOCAL_LOTE { get; set; }
        public bool BOOL_FLAG { get; set; }
        public Nullable<int> INT_ID_LOTE_ENTRADA { get; set; }
        public Nullable<int> INT_ID_LOTE_ARM_TERCEIRO { get; set; }
        public Nullable<int> INT_ID_LOTE_RESULTADO_REBENEFICIO { get; set; }
    
        public virtual autorizacao_generica autorizacao_generica { get; set; }
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual ICollection<lote_produto> lote_produto { get; set; }
        public virtual lote_armazem_terceiros lote_armazem_terceiros { get; set; }
        public virtual lote_resultado_rebeneficio lote_resultado_rebeneficio { get; set; }
    }
}