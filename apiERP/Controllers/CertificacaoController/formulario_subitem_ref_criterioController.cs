using ERP_COOPFAM.Controllers.ControllerGenerics;
using ERP_COOPFAM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiERP.Controllers.CertificacaoController
{
    class formulario_subitem_ref_criterioController : ControllerGenerics<formulario_subitem_ref_criterio>
    {
        public retornoApi ValidaDados(int id, string txtNrCriterio, int ? idNorma, int? idCriterio, bool ativo, bool cadastrar,
            DateTime dtCadastro, int idCadastrou, DateTime? dtAlterou, int? idAlterou, DateTime? dtExcluiu, int? idExcluiu, string txtRastrear,
            bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<formulario_subitem_ref_criterio> repository = new Repository<formulario_subitem_ref_criterio>();
            formulario_subitem_ref_criterio obj = new formulario_subitem_ref_criterio();

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_NUM_CRITERIO == txtNrCriterio && x.INT_ID_NORMA==idNorma && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_NUM_CRITERIO == txtNrCriterio && x.INT_ID_NORMA == idNorma && x.BOOL_ATIVO).INT_ID;
                objRetorno.Success = true;
                objRetorno.Message = "Registro já existente!!!";
                return objRetorno;
            }

            if (!cadastrar)
                obj = repository.Consulta_Id(id);


            if (ativo && string.IsNullOrEmpty(txtNrCriterio))
                objRetorno.Message = "Favor, informe o Número de Critério!!!";
            else if (ativo && idCriterio==null)
                objRetorno.Message = "Favor, informe o critério!!!";
            else if (ativo && idNorma == null)
                objRetorno.Message = "Favor, informe a norma!!!";
            else if (!ativo && repository.Any(x => x.TXT_NUM_CRITERIO == txtNrCriterio && x.INT_ID_NORMA == idNorma && x.BOOL_ATIVO))
                objRetorno.Message = "Referência já cadastrada!!!";
            else
            {
                objRetorno = preencheObj(txtNrCriterio, (int) idNorma, (int) idCriterio, ativo, cadastrar, dtCadastro, idCadastrou, dtAlterou, idAlterou,
                    dtExcluiu, idExcluiu, txtRastrear, ref obj, repository);
                objRetorno.id = obj.INT_ID;
                return objRetorno;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtNrCriterio, int idNorma, int idCriterio, bool ativo, bool cadastrar,
            DateTime dtCadastro, int idCadastrou, DateTime? dtAlterou, int? idAlterou, DateTime? dtExcluiu, int? idExcluiu, string txtRastrear,
            ref formulario_subitem_ref_criterio obj, IRepository<formulario_subitem_ref_criterio> repository)
        {
            obj.TXT_NUM_CRITERIO = txtNrCriterio;
            obj.INT_ID_CRITERIO = idCriterio;
            obj.INT_ID_NORMA = idNorma;
            
            obj.INT_ID_CADASTRO = idCadastrou;
            obj.DATE_CADASTRO = dtCadastro;
            obj.INT_ID_ALTERACAO = idAlterou;
            obj.DATE_ALTERACAO = dtAlterou;
            obj.INT_ID_EXCLUSAO = idExcluiu;
            obj.DATE_EXCLUSAO = dtExcluiu;

            obj.BOOL_ATIVO = ativo;

            return cadastraAltera(cadastrar, obj, repository, txtRastrear, ativo);
        }
    }
}