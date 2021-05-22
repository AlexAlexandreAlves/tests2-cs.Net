

namespace Senac
{
    public class Usuario
    {
        public string Login(string pEmail, string pSenha)
        {

            //Banco de Dados

            if (pEmail.Equals("marcelo.petri@prof.sc.senac.br") && pSenha.Equals("123456"))
            {

                return "Usuário logado";

            }
            else if (pEmail.Equals("marcelo.petri@prof.sc.senac.br") && pSenha.Equals(""))
            {

                return "Preencha a senha!";

            }
            else if (pEmail.Equals("") && pSenha.Equals("123456"))
            {

                return "Preencha o Email!";

            }
            else
            {

                return "E-mail ou senha incorretos";

            }

        }
        public bool VerificarNome(string pNome)
        {
            if (string.IsNullOrEmpty(pNome))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}