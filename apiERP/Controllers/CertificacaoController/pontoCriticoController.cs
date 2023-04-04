using ERP_COOPFAM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_COOPFAM.Controllers.CertificacaoController;
using apiERP;
using ERP_COOPFAM.Controllers.ControllerGenerics;
using apiERP.Controllers;


namespace ERP_COOPFAM.Controllers.CertificacaoController
{
    class pontoCriticoController : ControllerGenerics<ponto_critico>
    {
        public retornoApi ValidaDados(int id, string txtDescricao, int? idCertificacao, bool ativo, bool cadastrar, string txtRastrear, bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<ponto_critico> repository = new Repository<ponto_critico>();
            ponto_critico obj = new ponto_critico();

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_CERTIFICACAO == idCertificacao && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_CERTIFICACAO==idCertificacao && x.BOOL_ATIVO).INT_ID;
                objRetorno.Success = true;
                objRetorno.Message = "Registro já existente!!!";
                return objRetorno;
            }

            if (!cadastrar)
                obj = repository.Consulta_Id(id);

            if (ativo && string.IsNullOrEmpty(txtDescricao))
                objRetorno.Message= "Campo Descrição Vazio!!";
            else if (txtDescricao.Length > 5000)
                objRetorno.Message = "Limite de Caracteres excedido! Máximo 5000!";
            else if (idCertificacao == null)
                objRetorno.Message = "Por favor, selecione uma Certificação!";
            else if (ativo && repository.Any(x => x.INT_ID != id && x.INT_ID_CERTIFICACAO==idCertificacao && x.TXT_DESCRICAO == txtDescricao && x.BOOL_ATIVO))
                objRetorno.Message = "Ponto Crítico já cadastrado";
            else
            {  
                objRetorno=preencheObj(txtDescricao, (int)idCertificacao, ativo, cadastrar, txtRastrear, ref obj, repository);
                objRetorno.id = obj.INT_ID;
                return objRetorno;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtDescricao, int idCertificacao, bool ativo, bool cadastrar, string txtRastrear,
            ref ponto_critico obj, IRepository<ponto_critico> repository)
        {
            obj.TXT_DESCRICAO = txtDescricao;
            obj.INT_ID_CERTIFICACAO = idCertificacao;
            obj.BOOL_ATIVO = ativo;

            return cadastraAltera(cadastrar, obj, repository, txtRastrear, ativo);
        }
    }
}
