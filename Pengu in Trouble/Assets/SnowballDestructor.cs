using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballDestructor : MonoBehaviour
{
    void Update()
    {
        if ((GameObject.FindGameObjectsWithTag("DamagingSnowball")).Length >= 20)
        {
            Destroy(this.gameObject);
        }

    }
}
