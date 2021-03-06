using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PasswordProject.Models;
using PasswordProject;

namespace PasswordProject.Tests
{
  [TestClass]
  public class PasswordTest
  {


    [TestMethod]
    public void ResetMethod_Pass()
    {
      //Arrange
      int expectedResult = 0;
      //Act
      int actualResult = Password.Reset();
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PasswordChecker_Adds()
    {
      //Arrange
      Password testPassword = new Password();
      int expectedResult = 4;
      //Act
      int actualResult = testPassword.PasswordChecker("P455W0RD12");
      //Assert
      Assert.AreEqual(expectedResult, actualResult);
    }


  }
}
