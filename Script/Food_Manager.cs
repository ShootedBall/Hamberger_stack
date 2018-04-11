using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Manager : MonoBehaviour {

    public GameObject[] random_food;


	// Use this for initialization
	void Start () {
        
        //HOTFIX(1) 원인 미상 오류 (  Time scale 이 0으로 강제 지정 )
        Time.timeScale = 1;
        InvokeRepeating("Make", 3, 0.5f);

    }
	
	// Update is called once per frame
	void Update () {


		
	}

    void Make()
    {
        print("생성중!");
        int A = Random.Range(0, 6);
        A = Random.Range(0, 6);


        float X_position = Random.Range(-6, 1);
        Instantiate(random_food[A], new Vector3(X_position, 8, -1),transform.rotation);
    }
}
