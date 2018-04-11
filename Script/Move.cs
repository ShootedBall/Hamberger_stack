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

    }

    public void LMove()
    {
        if (dishPositon.x < 0.5)
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            
    }

    public void RMove()
    {
        if (dishPositon.x > -6)
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
           
    }
}
