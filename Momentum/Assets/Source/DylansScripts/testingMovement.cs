using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class testingMovement : MonoBehaviour
{
    // MAKE A PLAYER CLASS
    public GameObject player;
    private Animator p_animator;
    private Animation p_animation;
    private AnimationState p_states;
    private Transform p_transform;
    private Vector3 p;
    private Vector3 moveAmount3d;

    private void Start()
    {
        p_transform = player.GetComponent<Transform>();
        p_animator = player.GetComponent<Animator>();
        p = p_transform.position;
    }

    public void OnMove3d(InputAction.CallbackContext context)
    {
        moveAmount3d = context.ReadValue<Vector3>();


        // must be walking 
        if(moveAmount3d.y == 0.0f)
        {
            p_animator.Play("Walk");
        }
        else // must be jumping
        {
            p_animator.Play("Jump");
        }

        Debug.Log(context.phase);
    }

    public void Update()
    {
        // 3d movement
        p += moveAmount3d;
        p_transform.position = p;
    }
}
