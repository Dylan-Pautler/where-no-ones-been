using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.InputSystem;

public class SimpleActionsTest
{
    private Vector2 moveAmount;
    private UnityEvent m_MyEvent;
    private testingMovement sourceCode;
    private bool jumped;
    [Combinatorial]
    public IEnumerator OnMove(InputAction.CallbackContext context)
    {

        // arrange..
        // act
        sourceCode.OnMove(context);

       // moveAmount = context.ReadValue<Vector2>();

        // assert happens if moveAmount is equal to the ReadValue?
        Assert.Equals(moveAmount, context.ReadValue<Vector2>());

        yield return moveAmount;
    }

    [Combinatorial]
    public IEnumerator OnJump(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);

        sourceCode.OnJump(context);
        jumped = context.ReadValueAsButton();
        yield return jumped;
    }
    
}
