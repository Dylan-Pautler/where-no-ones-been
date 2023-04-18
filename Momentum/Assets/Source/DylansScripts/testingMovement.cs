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
    private Vector3 moveAmount3d;

    private void Start()
    {
        p_transform = player.GetComponent<Transform>();
        p = p_transform.position;
    }

    public void OnMove3d(InputAction.CallbackContext context)
    {
        moveAmount3d = context.ReadValue<Vector3>();
        Debug.Log(context.phase);
    }

    public void Update()
    {
        // 3d movement
        p += moveAmount3d;
        p_transform.position = p;
    }
}
