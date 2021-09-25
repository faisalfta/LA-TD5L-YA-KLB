using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scop : MonoBehaviour
{
    public Animator animator;

    private bool isscopd = false;
    

   
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            isscopd = !isscopd;
            animator.SetBool("scopd", isscopd);
        }
    }
}
