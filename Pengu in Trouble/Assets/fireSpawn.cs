using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSpawn : MonoBehaviour
{
    public GameObject firePillar;     
    public GameObject firePillarTwo;
    public float spawnTime;
    public int location;
    private float small_timer;
    private float despawn_timer;
    private int randomNumber;
    private int justSpawned;
    private GameObject fireMound;
    private GameObject flameEruption;


    // Update is called once per frame
    void Update()
    {
        small_timer += Time.deltaTime;   // Timer Counter
        if (small_timer > spawnTime)
        {
            SpawnRandom();       //Calling method SpawnRandom()
            small_timer = 0;        //Reseting timer to 0
        }


    }

    public void PillarLocation()
    {
        int interval = Random.Range(0,18);

        
        if (interval == justSpawned)
        {
            PillarLocation();
        }
        else
        {
            location = interval * 100;
            justSpawned = interval;
        }
        
    }
    IEnumerator delayForFire(Vector3 screenPosition)
    {
        yield return new WaitForSeconds(0.5f);
        flameEruption = Instantiate(firePillarTwo, screenPosition, Quaternion.identity);
    }



    public void SpawnRandom()
    {
        var destroyTime = 1f;
        PillarLocation();
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(location+50,340, Camera.main.farClipPlane / 2));
        fireMound = Instantiate(firePillar, screenPosition, Quaternion.identity);      
        StartCoroutine(delayForFire(screenPosition));
        Destroy(fireMound, destroyTime);
        Destroy(flameEruption, destroyTime + 0.5f);

    }
}
