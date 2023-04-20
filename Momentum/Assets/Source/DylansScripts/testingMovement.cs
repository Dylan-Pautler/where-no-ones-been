using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class testingMovement : MonoBehaviour
{
    // MAKE A PLAYER CLASS
    public GameObject player;
    public PlayerData playerclass;
    private Animator p_animator;
    private Animation p_animation;
    private AnimationState p_states;
    private Transform p_transform;
    private Vector3 moveAmount3d;
    [Tooltip("1.0f is exceptionally fast. Try numbers less than 1.0f")]
    public float speedMultiplier;

    private void Start()
    {
        p_transform = player.GetComponent<Transform>();
        p_animator = player.GetComponent<Animator>();
    }

    public void OnMove3d(InputAction.CallbackContext context)
    {
        moveAmount3d = context.ReadValue<Vector3>();


        // must be walking 
        

        Debug.Log(context.phase);
    }

    public void Update()
    {
        if(moveAmount3d == Vector3.zero)
        {
            playerclass.PlayAnimatorAnimation("Idle");

        }
        else if (moveAmount3d.y == 0.0f)
        {
            //p_animator.Play("Walk");
            playerclass.PlayAnimatorAnimation("Walk");
        }
        else // must be jumping
        {
            //p_animator.Play("Jump");
            playerclass.PlayAnimatorAnimation("Jump");
        }
        // 3d movement
        p_transform.position = p_transform.position + (moveAmount3d * speedMultiplier);
    }
}
