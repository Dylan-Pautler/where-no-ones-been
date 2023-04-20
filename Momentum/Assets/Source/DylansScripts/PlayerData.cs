using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // this objects animator
    private Animator animator;

    // ComponentsPlayer game object
    public GameObject child_components;
    private Transform transform_to_animate;
    private CapsuleCollider child_component_collider;
    private AnimatorClipInfo[] currentClips;

    // MainCamera game object
    public GameObject child_main_camera;
    

    private void Awake()
    {
        //act
        animator = this.gameObject.GetComponent<Animator>();
        transform_to_animate = child_components.transform;
        child_component_collider = child_components.GetComponent<CapsuleCollider>();
        //assertions???
    }

    public Animator GetAnimator()
    {
        return this.animator;
    }

    public void PlayAnimatorAnimation(string animName)
    {
        currentClips = animator.GetCurrentAnimatorClipInfo(0);

        if(currentClips.Length != 0 && currentClips[0].clip.name != animName)
        {
            animator.Play(animName);
        }
    }

    public GameObject GetChildComponents()
    {
        return child_components;
    }

    public Transform GetTransformToAnimate()
    {
        return transform_to_animate;
    }

    public CapsuleCollider GetCapsuleCollider()
    {
        return child_component_collider;
    }

    public GameObject GetMainCamera()
    {
        return child_main_camera;
    }
}
