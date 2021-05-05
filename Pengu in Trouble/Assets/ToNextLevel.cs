using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            {
                int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextLevel);
                SnowmanCharacteristics.health = 3;
            }

        }
    }
    public void FadeOut()
    {
        animator.SetTrigger("FadeOut");

    }
}
