using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class ScoreManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject TaxiSpawn;
    public GameObject WinningPanel;
    public GameObject Player;
    public GameObject Obstacle;
    public GameObject Water;
    public GameObject Coin;
    [SerializeField] TextMeshProUGUI scoreText;
    public int score;
    public int winScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("flousi : {0}", score);
        if (score < 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (score >= winScore)
        {
            //StartCoroutine(HandleWinCondition());
            WinningPanel.SetActive(true);
            TaxiSpawn.SetActive(true);
            Water.SetActive(false);
            Player.SetActive(false);
            Obstacle.SetActive(false);
            Coin.SetActive(false);
        }

    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }
    public void MoinScore(int points)
    {
        score -= points;
    }

    // Coroutine to handle the winning condition
    private IEnumerator HandleWinCondition()
    {
        WinningPanel.SetActive(true); // Activate the Winning Panel

        // Optional: Activate stars and start their animations
        foreach (Transform child in WinningPanel.transform)
        {
            child.gameObject.SetActive(true); // Ensure all children (e.g., stars) are active
        }

        // Activate Taxi Spawner
        yield return new WaitForSeconds(3); // Wait 3 seconds for animations to play

        Time.timeScale = 0; // Pause the game
    }
}
