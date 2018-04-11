using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Food : MonoBehaviour {
    public float Speed = 0.2F;
    public Vector3 food_position;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        food_position = transform.position;

        transform.Translate(Vector3.down * Speed * Time.deltaTime);
        //Speed += Time.deltaTime / 2;



    }



    void OnTriggerEnter2D(Collider2D Get)
    {
     
        if (Get.gameObject.name == "dish")
        {
            Destroy(this.gameObject);
            Game_manager.checkBuggerStack(this.tag);

        }


        if (Get.gameObject.name == "GarbageDestory")
        {
          
            Destroy(this.gameObject);
 
        }


    }
}
