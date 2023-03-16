using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    
    [Test]
    public void TestCalculating()
    {
      //Assign
      var exampleScript = new ExampleScript();
      //Act
      var result = exampleScript.CalculateMultiply(2, 3);
      
      //Assert
      Assert.AreEqual(6, result);
    }
    
    [TestCase(1,2,ExpectedResult = 2)] //Success
    [TestCase(2,2,ExpectedResult = 4)] //Success
    [TestCase(2,3,ExpectedResult = 5)] //Failed
    public int MultiTestCases(int x, int y)
    {
        var exampleScript = new ExampleScript();
        var result = exampleScript.CalculateMultiply(x, y);
        return result;
    }


}
