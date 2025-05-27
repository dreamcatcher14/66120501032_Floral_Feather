using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GardenUI : MonoBehaviour
{
    public float moveSpeed = 200f;
    bool isWalking = false;
    Rigidbody2D rb2d;
    Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = rb2d.GetComponent<Animator>();
    }
    public void MoveUp()
    {
        if (isWalking)
        {
            isWalking = true;
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            animator.SetTrigger(name: "isnotWalking");
            animator.SetTrigger(name: "isWalking");
        }
        else
        {
            isWalking = true;
        }
    }
    public void MoveDown()
    {
        if (isWalking)
        {
            isWalking = true;
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
            animator.SetTrigger(name: "isnotWalking");
            animator.SetTrigger(name: "isWalking");

            
        }
        else
        {
            isWalking = true;
        }
    }
}