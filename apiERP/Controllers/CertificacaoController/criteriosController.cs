using ERP_COOPFAM.Controllers.ControllerGenerics;
using ERP_COOPFAM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiERP.Controllers.CertificacaoController
{
    class criteriosController : ControllerGenerics<criterios>
    {
        public retornoApi ValidaDados(int id, string txtDescricao, string txtDescricaoCompleta, string txtNrNorma, int? idCertificacao, bool ativo, bool cadastrar,
            DateTime dtCadastro, int idCadastrou, DateTime ? dtAlterou, int ? idAlterou, DateTime ? dtExcluiu, int ? idExcluiu, string txtRastrear, 
            bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<criterios> repository = new Repository<criterios>();
            criterios obj = new criterios();

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_CERTIFICACAO == idCertificacao && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_CERTIFICACAO == idCertificacao && x.BOOL_ATIVO).INT_ID;
                objRetorno.Success = true;
                objRetorno.Message = "Registro já existente!!!";
                return objRetorno;
            }

            if (!cadastrar)
                obj = repository.Consulta_Id(id);


            if (ativo && string.IsNullOrEmpty(txtDescricao))
                objRetorno.Message = "Favor, informe o Critério!!!";
            else if (ativo && string.IsNullOrEmpty(txtDescricaoCompleta))
                objRetorno.Message = "Favor, informe o critério completo!!!";
            else if (ativo && string.IsNullOrEmpty(txtNrNorma))
                objRetorno.Message = "Favor, informe o Número da Norma!!!";
            else if (ativo && idCertificacao == null)
                objRetorno.Message = "Favor, informe a certificação!!!";
            else if (!ativo && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.BOOL_ATIVO && x.INT_ID != id))
                objRetorno.Message = "Critério já cadastrado!!!";
            else
            {
                objRetorno = preencheObj(txtDescricao, txtDescricaoCompleta, txtNrNorma, (int) idCertificacao, ativo, cadastrar, dtCadastro, idCadastrou, dtAlterou, idAlterou,
                    dtExcluiu, idExcluiu, txtRastrear,  ref obj, repository);
                objRetorno.id = obj.INT_ID;
                return objRetorno;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtDescricao, string txtDescricaoCompleta, string txtNrNorma, int idCertificacao, bool ativo, bool cadastrar,
            DateTime dtCadastro, int idCadastrou, DateTime? dtAlterou, int? idAlterou, DateTime? dtExcluiu, int? idExcluiu, string txtRastrear,
            ref criterios obj, IRepository<criterios> repository)
        {
            obj.TXT_DESCRICAO = txtDescricao;
            obj.INT_ID_CERTIFICACAO = idCertificacao;
            obj.TXT_NR_NORMA = txtNrNorma;
            obj.TXT_NORMA_COMPLETA = txtDescricaoCompleta;
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