using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 1f;
    [SerializeField] float runSpeed = 5f;

    private Rigidbody rb;
    private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();      
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }                
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }    
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);          
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }  
}
