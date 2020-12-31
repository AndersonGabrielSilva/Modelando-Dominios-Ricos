using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Refactor
        //Deixa tudo vermelho, depois deixa tudo verde, e depois refatora.
        //Está é a melhor forma de ficar bom em testes
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()//Retorne um erro sempre que o CNPJ for inválido.
        {
            var doc = new Document("123",Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()//Retorne um sucesso quando o CNPJ for Valido.
        {
           var doc = new Document("95776253000168",Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);

        }
        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()//Retorne um erro sempre que o CPF for inválido.
        {
             var doc = new Document("123",Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("42536145294")]
        [DataRow("45369854785")]
        [DataRow("96321478569")]
        [DataRow("96321478689")]
        public void ShouldReturnSucessWhenCPFsValid(string cpf)//Retorne um sucesso quando o CPF for Valido.
        {
            var doc = new Document(cpf, Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}
