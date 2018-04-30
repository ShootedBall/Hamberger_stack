using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homebtn : MonoBehaviour
{ 

    public void MoveScene()
    {
        SceneManager.LoadScene("[start_scene]");

    }

}
