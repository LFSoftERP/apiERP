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
    
    public partial class solicitar_visita
    {
        public solicitar_visita()
        {
            this.agendamento_certificacao = new HashSet<agendamento_certificacao>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_INSPECAO { get; set; }
        public int INT_ID_FORM_RESPOSTA { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OBS { get; set; }
    
        public virtual ICollection<agendamento_certificacao> agendamento_certificacao { get; set; }
        public virtual formulario_respostas formulario_respostas { get; set; }
        public virtual tipo_de_inspecao tipo_de_inspecao { get; set; }
    }
}
