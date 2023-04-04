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
    class procedimentoCriticoMedidaPrecaucaoController : ControllerGenerics<procedimento_critico_medida_precaucao>
    {
        public retornoApi ValidaDados(int id, string txtDescricao, int? idPontoCritico, bool ativo, bool cadastrar, string txtRastrear, bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<procedimento_critico_medida_precaucao> repository = new Repository<procedimento_critico_medida_precaucao>();
            procedimento_critico_medida_precaucao obj = new procedimento_critico_medida_precaucao();

            int auxPontoCritico = 0;
            if (idPontoCritico != null)
                auxPontoCritico = (int)idPontoCritico;

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_PONTO_CRITICO==auxPontoCritico && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_PONTO_CRITICO == auxPontoCritico && x.BOOL_ATIVO).INT_ID;
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
            else if (idPontoCritico == null)
                objRetorno.Message = "Por favor, selecione um ponto crítico!";
            else if (ativo && repository.Any(x => x.INT_ID != id && x.TXT_DESCRICAO == txtDescricao && x.INT_ID_PONTO_CRITICO == auxPontoCritico && x.BOOL_ATIVO))
                objRetorno.Message = "Ponto Crítico já cadastrado";
            else
            {
                objRetorno= preencheObj(txtDescricao, (int)idPontoCritico, ativo, cadastrar, txtRastrear, ref obj, repository);
                objRetorno.id = obj.INT_ID;
                return objRetorno;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtDescricao, int pontoCritico, bool ativo, bool cadastrar, string txtRastrear,
            ref procedimento_critico_medida_precaucao obj, IRepository<procedimento_critico_medida_precaucao> repository)
        {
            obj.TXT_DESCRICAO = txtDescricao;
            obj.INT_ID_PONTO_CRITICO = pontoCritico;
            obj.BOOL_ATIVO = ativo;

            return cadastraAltera(cadastrar, obj, repository, txtRastrear, ativo);
        }
    }
}
