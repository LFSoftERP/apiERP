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
    
    public partial class formulario_resposta_evidencia
    {
        public int INT_ID_ { get; set; }
        public int INT_ID_FORMULARIO_RESPOSTAS { get; set; }
        public string TXT_CAMINHO { get; set; }
        public string TXT_FORMATO { get; set; }
        public string TXT_FOTO_VIDEO_ARQUIVO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_LATITUDE { get; set; }
        public string TXT_LONGITUDE { get; set; }
        public bool BOOL_RESOLUCAO { get; set; }
    
        public virtual formulario_respostas formulario_respostas { get; set; }
    }
}
