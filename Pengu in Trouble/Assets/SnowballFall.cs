using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowballFall : MonoBehaviour
{
    public GameObject snowball;      
    public GameObject bigSnowball;      
    public Rigidbody2D snowballRb;
    public float spawnTime = 1f;           
    private float small_timer = 0; 
    private int i;


    // Update is called once per frame
    void Update()
    {
        small_timer += Time.deltaTime;   
        if (small_timer > spawnTime)
        {
            SpawnRandom();       
            small_timer = 0;       
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DamagingSnowball"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }
    public void SpawnRandom()
    {
        var snowCollection = 8f;
        GameObject snowClone;
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(700, Screen.height), Camera.main.farClipPlane / 2));
        snowClone = Instantiate(snowball, screenPosition, Quaternion.identity);
        GameObject.Destroy(snowClone, snowCollection);
    }

}
