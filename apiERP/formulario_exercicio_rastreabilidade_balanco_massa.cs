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
    
    public partial class formulario_exercicio_rastreabilidade_balanco_massa
    {
        public int INT_ID { get; set; }
        public int INT_ID_FORMULARIO_APP { get; set; }
        public bool BOOL_RASTREABILIDADE_BALANCO_MASSA { get; set; }
        public Nullable<int> INT_ID_CADASTRO_ENTRADA { get; set; }
        public decimal DECIMAL_SACAS { get; set; }
        public string TXT_NF { get; set; }
        public int INT_ID_HISTORICO_TALHAO { get; set; }
        public System.DateTime DATA_COLHEITA { get; set; }
        public System.DateTime DATA_INICIO_COLHEITA { get; set; }
        public System.DateTime DATA_FIM_COLHEITA { get; set; }
        public string TXT_DATA_PLANTIO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_CADASTRO { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DATE_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DATETIME_EXCLUSAO { get; set; }
        public string TXT_OBS { get; set; }
        public decimal DECIMAL_QUANTIDADE_TOTAL_COMERCIALIZADA { get; set; }
        public decimal DECIMAL_ESTOQUE { get; set; }
    
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual formulario_aplicar formulario_aplicar { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual historico_talhao historico_talhao { get; set; }
    }
}