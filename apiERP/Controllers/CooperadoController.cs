using ERP_COOPFAM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace apiERP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CooperadoController : ApiController
    {
        // GET api/values

        public List<dynamic> Get()
        {
            IRepository<cooperado> repository = new Repository<cooperado>();

            var teste = new db_coopfamEntities();
            var aux = teste.cooperado.Select(x => new { x.TXT_NOME, x.INT_ID, x.CHAR_STATUS }).Where(x =>x.INT_ID>5 && x.INT_ID<20 && x.CHAR_STATUS == "A").Take(5).ToList();
            //var ttt = teste.cooperado.Where(x => x.CHAR_STATUS == "A").ToList();

            return aux.Cast<dynamic>().ToList();
        }

        // GET api/values/5
        public cooperado Get(int id)
        {
            var teste =new db_coopfamEntities();
            var aux= teste.cooperado.Select(x=>new { x.TXT_NOME, x.INT_ID, x.CHAR_STATUS}).Where(x => x.CHAR_STATUS == "A").ToList();


            return new Repository<cooperado>().Consulta_Id(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
