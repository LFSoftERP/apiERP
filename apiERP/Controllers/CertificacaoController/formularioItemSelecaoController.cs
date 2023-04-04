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
    class formularioItemSelecaoController : ControllerGenerics<formulario_item_selecao>
    {
        public retornoApi ValidaDados(int id, string txtDescricao, string txtComposicao, string txtObs, string txtPrincipioAtivo, string txtDosagem,
            int? idTipoProdAgricola, int? idEmpresaFornProdAgr, int? idSeletiva, string diasReentrada, string diasCarencia, int? idPraga,
            string txtCor, bool pertimidoSim, bool permitidoNao, bool ativo, bool cadastrar, string txtRastrear, bool seJaExistirUmregistroIdenticoRetornarOIDeEncerrar)
        {
            retornoApi objRetorno = new retornoApi();
            objRetorno.Success = false;

            IRepository<formulario_item_selecao> repository = new Repository<formulario_item_selecao>();
            formulario_item_selecao obj = new formulario_item_selecao();

            int auxSeletiva = 0;
            if (idSeletiva != null)
                auxSeletiva = (int)idSeletiva;

            if (seJaExistirUmregistroIdenticoRetornarOIDeEncerrar && repository.Any(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_SELETIVA==idSeletiva && x.BOOL_ATIVO))
            {
                objRetorno.id = repository.FirstOrDefault(x => x.TXT_DESCRICAO == txtDescricao && x.INT_ID_SELETIVA == idSeletiva && x.BOOL_ATIVO).INT_ID;
                objRetorno.Success = true;
                objRetorno.Message = "Registro já existente!!!";
                return objRetorno;
            }

            formulario_seletiva objSeletiva = new formulario_seletiva();
            if (auxSeletiva > 0)
                objSeletiva = new Repository<formulario_seletiva>().Consulta_Id(auxSeletiva);

            if (!cadastrar)
                obj = repository.Consulta_Id(id);

            if (ativo && string.IsNullOrEmpty(txtDescricao))
                objRetorno.Message = "Campo Descrição Vazio!!";
            else if (txtDescricao.Length > 200)
                objRetorno.Message = "Limite de Caracteres excedido na descrição! Máximo 200!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && string.IsNullOrEmpty(txtComposicao))
                objRetorno.Message = "Campo Composição Vazio!!";
            else if (txtComposicao.Length > 200)
                objRetorno.Message = "Limite de Caracteres excedido na composição! Máximo 200!";
            else if (txtObs.Length > 500)
                objRetorno.Message = "Limite de Caracteres excedido na observação! Máximo 500!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && string.IsNullOrEmpty(txtPrincipioAtivo))
                objRetorno.Message = "Campo Princípio Ativo Vazio!!";
            else if (txtPrincipioAtivo.Length > 200)
                objRetorno.Message = "Limite de Caracteres excedido no Principio Ativo! Máximo 200!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && string.IsNullOrEmpty(txtDosagem))
                objRetorno.Message = "Campo Dosagem Vazio!!";
            else if (ativo && txtDosagem.Length > 200)
                objRetorno.Message = "Limite de Caracteres excedido na dosagem! Máximo 200!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && idTipoProdAgricola == null)
                objRetorno.Message = "Por favor, selecione um tipo de produto!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && idEmpresaFornProdAgr == null)
                objRetorno.Message = "Por favor, selecione uma empresa fornecedora do Produto";
            else if (ativo && idSeletiva == null)
                objRetorno.Message = "Por favor, selecione um Formulário Seletiva";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && idPraga == null)
                objRetorno.Message = "Por favor, selecione a praga a ser combatida";
            else if (ativo && string.IsNullOrEmpty(diasCarencia))
                objRetorno.Message = "Campo Dias de Carência Vazio!!";
            else if (ativo && string.IsNullOrEmpty(diasReentrada))
                objRetorno.Message = "Campo Dias de Reentrada Vazio!!";
            else if (ativo && objSeletiva.BOOL_PRODUTO_AGRICOLA && !pertimidoSim && !permitidoNao)
                objRetorno.Message = "Por favor, selecione se o produto é Permitido!!";
            else if (ativo && repository.Any(x => x.INT_ID != id && x.TXT_DESCRICAO == txtDescricao && x.INT_ID_SELETIVA == idSeletiva && x.BOOL_ATIVO))
                objRetorno.Message = "Formulário Item Seleção já cadastrado";
            else
            {
                objRetorno.Success = true;
                objRetorno= preencheObj(txtDescricao, txtComposicao, txtObs, txtPrincipioAtivo, txtDosagem, idTipoProdAgricola, idEmpresaFornProdAgr,
                    (int)idSeletiva, Convert.ToInt32(diasReentrada), Convert.ToInt32(diasCarencia), idPraga, txtCor, pertimidoSim, ativo, cadastrar,
                    txtRastrear, ref obj, repository);
                objRetorno.id = obj.INT_ID;
            }
            return objRetorno;
        }

        private retornoApi preencheObj(string txtDescricao, string txtComposicao, string txtObs, string txtPrincipioAtivo, string txtDosagem, 
            int ? idTipoProdAGricola, int ? idEmpresaFornProdAgr, int idSeletiva, int diasReentrada, int diasCarenvia, int ? idPraga, string txtCor, 
            bool permitido, bool ativo, bool cadastrar, string txtRastrear, ref formulario_item_selecao obj, 
            IRepository<formulario_item_selecao> repository)
        {
            obj.TXT_DESCRICAO = txtDescricao;
            obj.TXT_COMPOSICAO = txtComposicao;
            obj.TXT_OBS = txtObs;
            obj.TXT_PRINCIPIO_ATIVO = txtPrincipioAtivo;
            obj.TXT_DOSAGEM = txtDosagem;
            obj.INT_ID_TIPO_PROD_AGRICOLA = idTipoProdAGricola;
            obj.INT_ID_EMPRESA_FORN_PROD_AGRICOLA = idEmpresaFornProdAgr;
            obj.INT_ID_SELETIVA = idSeletiva;
            obj.INT_DIAS_REENTRADA = diasReentrada;
            obj.INT_DIAS_CARENCIA = diasCarenvia;
            obj.INT_ID_PRAGA_DOENCA_A_SER_COMBATIDA = idPraga;
            obj.TXT_COR = txtCor;
            obj.BOOL_PERMITIDO_NAO_PERMITIDO = permitido;
            obj.BOOL_ATIVO = ativo;

            return cadastraAltera(cadastrar, obj, repository, txtRastrear, ativo);
        }   
    }
}
