using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class testingMovement : MonoBehaviour
{
    // MAKE A PLAYER CLASS
    public GameObject player;
    private Transform p_transform;
    private Vector3 p;
    private Vector2 moveAmount;

    private void Start()
    {
        p_transform = player.GetComponent<Transform>();
        p = p_transform.position;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        Debug.Log(context.ReadValue<Vector2>());
        // arrange..
        // act
        moveAmount = context.ReadValue<Vector2>();
        p.x += moveAmount.x;
        p.z += moveAmount.y;

        p_transform.position = p;

        // assert happens if moveAmount is equal to the ReadValue?
        
    }

}
