using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class testingMovement : MonoBehaviour
{
    private Vector2 moveAmount;

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        Debug.Log(context.ReadValue<Vector2>());
        // arrange..
        // act
        moveAmount = context.ReadValue<Vector2>();

        // assert happens if moveAmount is equal to the ReadValue?
        //Assert.Equals(moveAmount, context.ReadValue<Vector2>());
    }

}
