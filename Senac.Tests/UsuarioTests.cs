using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Senac.Tests
{
    [TestClass]
    public class UsuarioTests
    {

        [TestMethod]

        public void Login_EmailSenhaCorretos()
        {

            Usuario usuario = new Usuario();

            var resultado = usuario.Login("marcelo.petri@prof.sc.senac.br", "123456");

            Assert.AreEqual("Usuário logado", resultado);

        }



        [TestMethod]

        public void Login_EmailIncorreto()
        {

            Usuario usuario = new Usuario();

            var resultado = usuario.Login("marcelo.petri@senac.br", "123456");



            Assert.AreEqual("E-mail ou senha incorretos", resultado);

        }

        [TestMethod]
        public void Login_SenhaIncorreto()
        {
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("marcelo.petri@prof.sc.senac.br", "123");

            Assert.AreEqual("E-mail ou senha incorretos", resultado);
        }

        [TestMethod]

        public void Login_SenhaVazia()
        {

            Usuario usuario = new Usuario();

            var resultado = usuario.Login("marcelo.petri@prof.sc.senac.br", "");

            Assert.AreEqual("Preencha a senha!", resultado);

        }

        public void Login_EmailVazio()
        {

            Usuario usuario = new Usuario();

            var resultado = usuario.Login("", "123456");

            Assert.AreEqual("Preencha o e-mail!", resultado);

        }


    }
}