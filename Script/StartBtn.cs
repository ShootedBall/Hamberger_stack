using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour {

    public void SceneChange()
    {
        SceneManager.LoadScene("[first_scene]");
    }


    public void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if(GetComponent<SPriteR>)




        }
        


    }

}
