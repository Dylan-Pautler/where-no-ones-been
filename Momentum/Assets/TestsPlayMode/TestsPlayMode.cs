using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestsPlayMode
{



    // A Test behaves as an ordinary method
    [Test]
    public void TestsPlayModeSimplePasses()
    {
        //// Use the Assert class to test conditions
        //// Arrange
        //GameObject player;
        //// Act
        //player = GameObject.FindGameObjectWithTag("Player");
        //// Assert
        //Assert.IsNotNull(player);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestsPlayModeWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
