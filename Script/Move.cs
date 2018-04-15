using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int Speed;
    public Vector3 dishPositon;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        dishPositon = gameObject.transform.position;

        //Move to left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LMove();
        }

        //Move to right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RMove();
        }



        //Active Touch
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

       

            //시작좌표기억
            if ((touch.position.x < -37) && (touch.position.x > -77))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }

            else if ((touch.position.x < 85) && (touch.position.x > 125))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            }


        }

    }

    public void LMove()
    {
        if (dishPositon.x > -6)
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            
    }

    public void RMove()
    {
       if (dishPositon.x < 0.5)
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
           
    }
}
