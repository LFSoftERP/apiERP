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
    
    public partial class estimativa
    {
        public estimativa()
        {
            this.quebra_de_safra_estimativa = new HashSet<quebra_de_safra_estimativa>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_TALHAO { get; set; }
        public int INT_ESTIMATIVA { get; set; }
        public string TXT_SAFRA { get; set; }
        public System.DateTime DATE_DATA_ESTIMATIVA { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public Nullable<float> INT_LITROS_POR_PE { get; set; }
        public Nullable<float> INT_LITROS_POR_SACA { get; set; }
        public int INT_QTD_SACAS { get; set; }
        public bool BOOL_ORG_CONV { get; set; }
        public bool BOOL_CAFE_EM_TRANSICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_STATUS_ESTIMATIVA { get; set; }
    
        public virtual talhao talhao { get; set; }
        public virtual ICollection<quebra_de_safra_estimativa> quebra_de_safra_estimativa { get; set; }
    }
}