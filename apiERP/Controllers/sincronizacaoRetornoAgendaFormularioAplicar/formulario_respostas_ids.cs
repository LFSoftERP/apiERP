using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiERP.Controllers.sincronizacaoRetornoAgendaFormularioAplicar
{
    public class formulario_respostas_ids
    {
        public formulario_respostas_ids()
        {
            this.form_resposta_nc_criterio_ids = new HashSet<form_resposta_nc_criterio_ids>();
            this.formulario_resposta_documento_comprobatorio_ids = new HashSet<formulario_resposta_documento_comprobatorio_ids>();
            this.formulario_resposta_evidencia_ids = new HashSet<formulario_resposta_evidencia_ids>();
            this.formulario_resposta_seletiva_ids = new HashSet<formulario_resposta_seletiva_ids>();
            //this.solicitar_visita_ids = new HashSet<solicitar_visita_ids>();
        }

        public int INT_ID { get; set; }
        public int id { get; set; }
       
        public virtual ICollection<form_resposta_nc_criterio_ids> form_resposta_nc_criterio_ids { get; set; }
        //public virtual formulario_aplicar_ids formulario_aplicar_ids { get; set; }
        public virtual ICollection<formulario_resposta_documento_comprobatorio_ids> formulario_resposta_documento_comprobatorio_ids { get; set; }
        public virtual ICollection<formulario_resposta_evidencia_ids> formulario_resposta_evidencia_ids { get; set; }
        public virtual ICollection<formulario_resposta_seletiva_ids> formulario_resposta_seletiva_ids { get; set; }
        
    }
}