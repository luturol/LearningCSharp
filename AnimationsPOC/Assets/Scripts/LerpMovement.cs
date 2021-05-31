using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxisRaw("Horizontal");              
        animator.SetFloat("Walking", Mathf.Abs(movement));

        var jump = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Jumping", jump);

        var kick = Input.GetKeyDown(KeyCode.Space);
        animator.SetBool("Kick", kick);

        var run = Input.GetKeyDown(KeyCode.LeftShift);
        animator.SetBool("Running", run);
    }
}
