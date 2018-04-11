using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Manager : MonoBehaviour {

    public GameObject[] random_food;


	// Use this for initialization
	void Start () {
        InvokeRepeating("Make", 3, 0.5f);

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    void Make()
    {
        int A = Random.Range(0, 6);
        A = Random.Range(0, 6);


        float X_position = Random.Range(-6, 1);
        Instantiate(random_food[A], new Vector3(X_position, 8, -1),transform.rotation);
    }
}
