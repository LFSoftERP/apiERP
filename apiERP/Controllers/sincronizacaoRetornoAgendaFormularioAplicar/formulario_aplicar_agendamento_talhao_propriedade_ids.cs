using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiERP.Controllers.sincronizacaoRetornoAgendaFormularioAplicar
{
    public class formulario_aplicar_agendamento_talhao_propriedade_ids
    {
        public int INT_ID { get; set; }
        public int id { get; set; }
        public virtual formulario_aplicar_ids formulario_aplicar { get; set; }
    }
}