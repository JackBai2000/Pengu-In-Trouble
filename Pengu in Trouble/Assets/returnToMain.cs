using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMain : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Start Menu");
            SnowmanCharacteristics.health = 3;
        }
        
    }
}
