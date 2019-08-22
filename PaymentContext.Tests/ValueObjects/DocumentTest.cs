using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
  [TestClass]
  public class DocumentTest
  {
    //Read, Green, Refactor
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
      var doc = new Document("123", Domain.Enums.EDocumentType.CNPJ);
      Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
      var doc = new Document("31083531000144", Domain.Enums.EDocumentType.CNPJ);
      Assert.IsTrue(doc.Valid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
      var doc = new Document("123", Domain.Enums.EDocumentType.CPF);
      Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
      var doc = new Document("42036072801", Domain.Enums.EDocumentType.CPF);
      Assert.IsTrue(doc.Valid);
    }
  }
}