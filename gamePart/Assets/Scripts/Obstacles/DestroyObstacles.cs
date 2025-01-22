using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public int moin500;
    private ScoreManager theScoreManager;


    private Transform boxTransform;
    private Transform explosionTransform;

    private Animator boxAnimator;
    private Animator explosionAnimator;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        theScoreManager = FindObjectOfType<ScoreManager>();

        // Access child objects by their names
        boxTransform = transform.Find("Box");
        explosionTransform = transform.Find("Explosion");

        // Ensure the children are found
        if (boxTransform != null)
        {
            boxAnimator = boxTransform.GetComponent<Animator>();
            Debug.Log("Box child found and Animator component accessed.");
        }
        else
        {
            Debug.LogError("Box child not found!");
        }

        if (explosionTransform != null)
        {
            explosionAnimator = explosionTransform.GetComponent<Animator>();
            Debug.Log("Explosion child found and Animator component accessed.");
        }
        else
        {
            Debug.LogError("Explosion child not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            explosionAnimator.SetTrigger("Explode");
            boxAnimator.SetTrigger("Explode");
            theScoreManager.MoinScore(moin500);
            //Destroy(this.gameObject);
        }
        else if (collision.tag == "Water")
        {
            Destroy(this.gameObject);
        }
    }
}
