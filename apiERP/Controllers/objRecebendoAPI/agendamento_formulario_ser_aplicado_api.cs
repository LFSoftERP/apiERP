//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace objRecebendoAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class agendamento_formulario_ser_aplicado_api
    {
        public agendamento_formulario_ser_aplicado_api()
        {
            this.formulario_aplicar = new HashSet<formulario_aplicar_api>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_FORMULARIO { get; set; }
        public int INT_ID_AGENDAMENTO { get; set; }
        public bool BOOL_ATIVO { get; set; }

        public virtual agendamento_certificacao_api agendamento_certificacao { get; set; }

        public virtual ICollection<formulario_aplicar_api> formulario_aplicar { get; set; }
    }
}
