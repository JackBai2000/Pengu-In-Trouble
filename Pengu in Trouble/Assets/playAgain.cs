using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{
    Scene playagain;

    void Update()
    {
        playagain = SceneManager.GetActiveScene();
        if (Input.GetButtonDown("Jump") && playagain.buildIndex >= 1){
            {
                int previousLevel = SceneManager.GetActiveScene().buildIndex - 1;
                SceneManager.LoadScene(previousLevel);
                SnowmanCharacteristics.health = 3;
            }

        }
        
    }
}
