using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests {
    [TestClass]

    public class DocumentsTest {
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid () {
            var doc = new Document ("123", EDocumentType.CNPJ);
            Assert.IsTrue (doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid () {
            var doc = new Document ("22511602000146", EDocumentType.CNPJ);
            Assert.IsTrue (doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid () {
            var doc = new Document ("123", EDocumentType.CPF);
            Assert.IsTrue (doc.Invalid);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("85284205073")]
        [DataRow("85284205073")]
        [DataRow("85284205073")]        
        public void ShouldReturnSuccessWhenCPFIsValid (string cpf) {
            var doc = new Document (cpf, EDocumentType.CPF);
            Assert.IsTrue (doc.Valid);
        }
    }
}