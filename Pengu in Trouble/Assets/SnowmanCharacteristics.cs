using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowmanCharacteristics : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public static int health = 3;
    public bool invincibility;
    public float takingDamage = 0;
    public float invincibilityTime = 3f;
    public GameObject Pengu;
    Scene gameOver;



    IEnumerator iFrames()
    {
        while (takingDamage <= invincibilityTime)
        {
            takingDamage += Time.deltaTime;
            Debug.Log(takingDamage);
            invincibility = true;
            yield return null;
        }
        takingDamage = 0;
        invincibility = false;
        yield return null;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((this.CompareTag("Player")) && (other.CompareTag("DamagingSnowball") && (invincibility == false)))
        {
            currentInterObj = other.gameObject;
            this.GetComponent<Animation>().Play();
            health = health - 1;
            
            StartCoroutine(iFrames());

        }
        if (health <= 0)
        {
            if (SceneManager.GetActiveScene().name == "GameScene")
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                SceneManager.LoadScene("GameOver(Fire)");
            }
        }
    }

}
