using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioVendas.Classes
{
    class Tratamento
    {
        #region CAMPO VAZIO
        //VERIFICA SE O CAMPO ESTÁ VAZIO
        public bool CampoVazio(Control tb_campo, string campo)
        {
            if (string.IsNullOrEmpty(tb_campo.Text.Trim()))
            {
                MessageBox.Show("Campo " + campo + " está vazio. Favor preencher.");
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region VALIDA EMAIL
        // VERIFICA SE O EMAIL DIGITADO TEM O @ E DEPOIS DELE TEM O PONTO
        public static bool validaEmail(string email)
        {
            bool emailValido = false;

            //REGEX OBTIDO DA DOCUMENTAÇÃO DA MICROSOFT
            string emailRegex = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            try
            {
                emailValido = Regex.IsMatch(email, emailRegex);
            }
            catch (RegexMatchTimeoutException)
            {
                emailValido = false;
            }

            return emailValido;
        }
        #endregion

        #region LOCALIZA CEP

        // VERIFICA SE O CEP FOI DIGITADO E DEIXA OS DADOS EM MAIÚSCULA E SEM ESPAÇOS EM BRANCO
        public static void LocalizaCEP()
        {
            string cep = string.Empty;
            string end;
            string cidade;
            string estado;
            string bairro;

            if (!string.IsNullOrWhiteSpace(cep)) // Só executa se o campo cep estiver com algum valor digitado
            {
                using (var ws = new WebServiceCorreios.AtendeClienteClient()) // Referencia o web service com a variavel ws
                {
                    try
                    {
                        var endereco = ws.consultaCEP(cep);
                        end = endereco.end.ToUpper();
                        cidade = endereco.cidade.ToUpper();
                        estado = endereco.uf.ToUpper();
                        bairro = endereco.bairro.ToUpper();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, cep, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor informar o CEP!", cep, MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }
        #endregion

    }
}
