using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiERP.Controllers.sincronizacaoRetornoAgendaFormularioAplicar
{
    public class formulario_aplicar_ids
    {
        public formulario_aplicar_ids()
        {
            this.formulario_aplicar_agendamento_talhao_propriedade = new HashSet<formulario_aplicar_agendamento_talhao_propriedade>();
            this.formulario_aplicar_produtos_utilizados_na_lavoura = new HashSet<formulario_aplicar_produtos_utilizados_na_lavoura>();
            this.formulario_exercicio_rastreabilidade_balanco_massa = new HashSet<formulario_exercicio_rastreabilidade_balanco_massa>();
            this.formulario_respostas_ids = new HashSet<formulario_respostas_ids>();
        }

        public int INT_ID { get; set; }
        public int id { get; set; }
               
        public virtual ICollection<formulario_aplicar_agendamento_talhao_propriedade> formulario_aplicar_agendamento_talhao_propriedade { get; set; }
        public virtual ICollection<formulario_aplicar_produtos_utilizados_na_lavoura> formulario_aplicar_produtos_utilizados_na_lavoura { get; set; }
        public virtual ICollection<formulario_exercicio_rastreabilidade_balanco_massa> formulario_exercicio_rastreabilidade_balanco_massa { get; set; }
        public virtual ICollection<formulario_respostas_ids> formulario_respostas_ids { get; set; }
    }
}