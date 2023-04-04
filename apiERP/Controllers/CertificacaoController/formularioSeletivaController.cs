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
    class formularioSeletivaController:ControllerGenerics<formulario_seletiva>
    {

        public retornoApi ValidaDados(int id, string txtDescricao, bool chcProdAgricola, bool ativo, bool cadastrar, string txtRastrear, bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<formulario_seletiva> repository = new Repository<formulario_seletiva>();
            formulario_seletiva obj = new formulario_seletiva();

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_DESCRICAO == txtDescricao && x.BOOL_ATIVO).INT_ID;
                objRetorno.Success = true;
                objRetorno.Message = "Registro já existente!!!";
                return retorno;
            }

            if (!cadastrar)
                obj = repository.Consulta_Id(id);

            if (ativo && string.IsNullOrEmpty(txtDescricao))
                objRetorno.Message= "Campo Descrição Vazio!!";
            else if (txtDescricao.Length > 200)
                objRetorno.Message = "Limite de Caracteres excedido! Máximo 200!";
            else if (ativo && repository.Any(x => x.INT_ID != id && x.TXT_DESCRICAO == txtDescricao && x.BOOL_ATIVO))
                objRetorno.Message = "Formulário já cadastrado";
            else
            {
                objRetorno= preencheObj(txtDescricao, chcProdAgricola, ativo, cadastrar, txtRastrear, ref obj, repository);
                objRetorno.id = obj.INT_ID;
                return objRetorno;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtDescricao, bool chcProdAgricola,bool ativo, bool cadastrar, string txtRastrear,
            ref formulario_seletiva obj, IRepository<formulario_seletiva> repository)
        { 
            obj.TXT_DESCRICAO = txtDescricao;
            obj.BOOL_PRODUTO_AGRICOLA = chcProdAgricola;
            obj.BOOL_ATIVO = ativo;


            return cadastraAltera(cadastrar, obj, repository, txtRastrear, ativo);
        }
    }
}
