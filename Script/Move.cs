using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Move : MonoBehaviour
{
    public int Speed;
    bool left_collider = false;
    bool right_collider = false;


    float directionX;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
 
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(directionX * 90, 0);


        if (left_collider == true)
        {

            if (rb.velocity.x <= 0)
                rb.velocity = new Vector2(0, 0);
            else
                left_collider = false;

        }


        if (right_collider == true)
        {
            if (rb.velocity.x > 0)
                rb.velocity = new Vector2(0, 0);
            else
                right_collider = false;

        }


    }


    void OnTriggerEnter2D(Collider2D Get)
    {

        //TestLine

        if (Get.gameObject.name == "Left_transparent_wall")
        {
                left_collider = true;

        }


        if (Get.gameObject.name == "Right_transparent_wall")
        {
                right_collider = true;

        }


    }


}
