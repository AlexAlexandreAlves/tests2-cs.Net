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

    }
}