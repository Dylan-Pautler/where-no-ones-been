using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Cinemachine;
public class CameraManagerTest
{
    // References
    // will need a reference to the cinemachine
    public GameObject cvc1; // Cinemachine Virtual Camera
    private string virtualCameraLabel = "VirtualCamera";
    
    // create references to the usingcinemachinetest so that we can get a solid
    // pipeline of actual game code and functional testing
    [Test]
    public void Start()
    {
        // arrange
        cvc1 = GameObject.FindWithTag(virtualCameraLabel);
        // act
        // assert
        Assert.AreEqual(virtualCameraLabel, "VirtualCamera");
        Assert.IsNotNull(cvc1);
    }

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
