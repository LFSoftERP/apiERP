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
    
    public partial class historico_talhao
    {
        public historico_talhao()
        {
            this.formulario_exercicio_rastreabilidade_balanco_massa = new HashSet<formulario_exercicio_rastreabilidade_balanco_massa>();
            this.norma_talhao_historico = new HashSet<norma_talhao_historico>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_TALHAO { get; set; }
        public int INT_ID_PROPRIEDADE { get; set; }
        public float FLOAT_NUMERO_PES { get; set; }
        public float FLOAT_ESPACAMENTO_X { get; set; }
        public float FLOAT_ESPACAMENTO_Y { get; set; }
        public string TXT_NOME { get; set; }
        public string TXT_AREA_PRODUCAO { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_STATUS { get; set; }
        public System.DateTime DATA { get; set; }
    
        public virtual ICollection<formulario_exercicio_rastreabilidade_balanco_massa> formulario_exercicio_rastreabilidade_balanco_massa { get; set; }
        public virtual propriedade propriedade { get; set; }
        public virtual talhao talhao { get; set; }
        public virtual ICollection<norma_talhao_historico> norma_talhao_historico { get; set; }
    }
}
