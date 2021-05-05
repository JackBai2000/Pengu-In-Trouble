using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class swordSwing : MonoBehaviour
{

    public float moveSpeed = 100f;
    public Rigidbody2D rb;
    public float range;
    public Transform meleeRange;
    public Animator animator;
    public Rigidbody2D candycane;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown("z"))
        {
           
            //animator.SetBool("Swinging", true);
            //SwingAttack();
            if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Swing"))
            {
                Debug.Log("hiimworking");
                animator.SetBool("Swinging", false);
                
            }

        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void SwingAttack()
    {
        Collider2D[] c = Physics2D.OverlapCircleAll(meleeRange.position, 1.0f);
        GameObject[] hitObject = new GameObject[c.Length];
        int x = 0;
        foreach (Collider2D col in c)
        {
            if ((col.gameObject.CompareTag("CandyCane")) || (col.gameObject.CompareTag("Player")) || (col.gameObject.CompareTag("Wall")))
            {

            }
            else
            {
                hitObject[x] = col.gameObject;
                GameObject clone = col.gameObject;
                Destroy(col.gameObject);
                Debug.Log("Hit " + hitObject[x].name);
            }

        }


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
