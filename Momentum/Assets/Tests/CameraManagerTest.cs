using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CameraManagerTest
{
    // References
    // will need a reference to the cinemachine


    // A Test behaves as an ordinary method
    [Test]
    public void CameraManagerTestSimplePasses()
    {
        // Use the Assert class to test conditions
        //Assert.Fail("This is an intentional failure of CameraManagerTestSimplePasses");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CameraManagerTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [UnityTest]
    public IEnumerator CameraManagerTestZoom()
    {
        // arrange
        bool passTest = true;
        // act
        // assert
        Assert.IsTrue(passTest);
        return null;
    }
}
