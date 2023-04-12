using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.InputSystem;

public class SimpleActionsTest : MonoBehaviour
{
    private Vector2 moveAmount;
    private UnityEvent m_MyEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        
        // arrange..
        // act
        moveAmount = context.ReadValue<Vector2>();

        // assert happens if moveAmount is equal to the ReadValue?
        Assert.Equals(moveAmount, context.ReadValue<Vector2>());
    }

    void Update()
    {
        
    }
}
