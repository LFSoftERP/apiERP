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
    
    public partial class instrucao_lote_resultado_para_gerar
    {
        public instrucao_lote_resultado_para_gerar()
        {
            this.lote_resultado_rebeneficio = new HashSet<lote_resultado_rebeneficio>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_INSTRUCAO { get; set; }
        public int INT_ID_TIPO_LOTE { get; set; }
        public string TXT_LOTE_SERA_GERADO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_TIPO { get; set; }
        public string INT_DEFEITO { get; set; }
        public Nullable<int> INT_ID_TIPO_SACARIA { get; set; }
        public string TXT_OIC { get; set; }
        public decimal DECIMAL_QTD_ESTIMADA { get; set; }
        public Nullable<int> INT_ID_TIPO_CAFE { get; set; }
        public Nullable<int> INT_ID_SUBTIPO { get; set; }
    
        public virtual instrucao_preparo instrucao_preparo { get; set; }
        public virtual subtipo_norma subtipo_norma { get; set; }
        public virtual tipo_cafe_rebeneficiado tipo_cafe_rebeneficiado { get; set; }
        public virtual tipo_sacaria tipo_sacaria { get; set; }
        public virtual tipo_lote_rebeneficio_para_gerar tipo_lote_rebeneficio_para_gerar { get; set; }
        public virtual ICollection<lote_resultado_rebeneficio> lote_resultado_rebeneficio { get; set; }
    }
}
