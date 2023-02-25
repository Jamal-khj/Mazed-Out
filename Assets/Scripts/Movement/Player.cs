using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Animator animator;

    float mouseX;
    float mouseY;

    bool isAlive;
    void Start()
    {
       isAlive = true;
    }


    void Update()
    {
        if (isAlive)
        {
            mouseX += Input.GetAxis("Mouse X");
            mouseY += Input.GetAxis("Mouse Y");

            transform.rotation = Quaternion.Euler(0, mouseX, 0);
            Camera.main.transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0);

            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("walk", true);
                animator.SetFloat("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))   
            {
                animator.SetBool("walk", true);
                animator.SetFloat("Direction", -1);
            }
            else
            {
                animator.SetBool("walk", false);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Run", true);
            }
            else
            {
                animator.SetBool("Run", false);
            }
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            animator.SetBool("Die", true);
            isAlive = false;
        }
        else
        {
            animator.SetBool("Die", false);
        }
    }
}
