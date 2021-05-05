using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
   

public class PlayButtonScript : MonoBehaviour

{
    public Animator fadeOut;
    public void testing()
    {
        fadeOut.SetTrigger("FadeOut");
        StartCoroutine(delayForAnimation());
        
    }

    IEnumerator delayForAnimation()
    {
        fadeOut.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameScene");
    }
}
  