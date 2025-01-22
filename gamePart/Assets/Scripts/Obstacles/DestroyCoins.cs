using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{
    private GameObject player;
    public int add100;
    private ScoreManager theScoreManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            theScoreManager.AddScore(add100);
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}
