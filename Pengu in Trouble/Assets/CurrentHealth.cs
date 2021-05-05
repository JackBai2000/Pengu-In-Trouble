using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHealth : MonoBehaviour
{
    public Text currentHealth;
    public Texture2D heart;
    public int lives;

    void Start()
    {
        lives = SnowmanCharacteristics.health;
        if (heart == null) { heart = new Texture2D(1, 1); }
    }

    void OnGUI()
    {
        float space;
        int ii = SnowmanCharacteristics.health;
        space = 40;
        while (ii > 0)
        {
            ii--;
            GUI.DrawTexture(new Rect(space, 20, 50, 50), heart);
            space += 40;
        }
    }

}
