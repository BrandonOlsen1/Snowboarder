using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float torqueAmountOther = -1f;

    [SerializeField] float boostspeed = 25f;
    [SerializeField] float basespeed = 15f;

    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
        NewMethod();
        NewMethod1();
        }
    }

    public void DisableControllers()
    {
        canMove = false;

    }

     void NewMethod1()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostspeed;
        }
        else 
        {
            surfaceEffector2D.speed = basespeed;
        }
    }

    void NewMethod()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(torqueAmountOther);
        }
    }
}
