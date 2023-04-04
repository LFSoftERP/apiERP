using ERP_COOPFAM.Model.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiERP.Controllers
{
    public class formularioAplicarController : ApiController
    {
        // GET: api/formularioAplicar
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/formularioAplicar/5
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/formularioAplicar
        public void Post([FromBody]formulario_aplicar obj)
        {
            //try
            //{
            //    IRepository<agendamento_certificacao> repository = new Repository<agendamento_certificacao>();
            //    agendamento_certificacao obj = repository.Consulta_Id(objAgCert.INT_ID);
            //}
            //catch (Exception ex)
            //{
            //    return JObject.Parse("{result: \"" + false + "\"}");
            //}





            //bool retorno = true;
            //try
            //{
            //    IRepository<agendamento_certificacao> repository = new Repository<agendamento_certificacao>();
            //    agendamento_certificacao obj = repository.Consulta_Id(objAgCert.INT_ID);

            //    obj.TXT_MOTIVO = objAgCert.TXT_MOTIVO;
            //    obj.BOOL_VISITA_CANCELADA = objAgCert.BOOL_VISITA_CANCELADA;
            //    obj.DATE_ALTERACAO = objAgCert.DATE_ALTERACAO;
            //    obj.INT_ID_ALTERACAO = objAgCert.INT_ID_ALTERACAO;
            //    obj.BOOL_SINCRONIZACAO_FINALIZOU = true;
            //    obj.DATE_SINC_FIN = DateTime.Now;

            //    repository.Update(obj);
            //    if (!repository.SaveChanges("Cancela Agenda API"))
            //        retorno = false;

            //    return JObject.Parse("{result: \"" + retorno + "\"}");
            //}
            //catch (Exception ex)
            //{
            //    return JObject.Parse("{result: \"" + false + "\"}");
            //}
        }

        // PUT: api/formularioAplicar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/formularioAplicar/5
        public void Delete(int id)
        {
        }
    }
}
