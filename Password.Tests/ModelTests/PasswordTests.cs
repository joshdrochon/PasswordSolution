using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PasswordProject.Models;
using PasswordProject;

namespace PasswordProject.Tests
{
  [TestClass]
  public class PasswordTest : IDisposable
  {
    public void Dispose()
    {
      Password.Reset();
    }

    [TestMethod]
    public void Reset_Pass()
    {
      //Arrange
      int expectedResult = 2;
      //Act
      int actualResult = Password.Reset();
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }


  }
}
