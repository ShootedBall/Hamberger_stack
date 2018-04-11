using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour {



    public static void PlaySound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
