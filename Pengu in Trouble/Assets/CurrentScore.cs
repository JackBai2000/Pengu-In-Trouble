using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CurrentScore : MonoBehaviour
{
    public Text score;
    public float currentTime;
    public float nextLevelTime;
    public float toNextLevel = 10;
    Scene playagain;

    void Update()
    {
        playagain = SceneManager.GetActiveScene();
        if (Input.GetButtonDown("Jump") && playagain.buildIndex == 3)
        {
            SceneManager.LoadScene("GameScene");
            currentTime = 0;
        }

        currentTime += Time.deltaTime;
        nextLevelTime = toNextLevel - currentTime;
        score.text = (toNextLevel - currentTime).ToString("0");
        if (currentTime >= toNextLevel)
        {
            int nextlevel = SceneManager.GetActiveScene().buildIndex + 2;
            SceneManager.LoadScene(nextlevel);
            currentTime = 0;
        }

    }

}
