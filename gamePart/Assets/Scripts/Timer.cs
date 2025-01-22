//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;

//public class Timer : MonoBehaviour
//{
//    [SerializeField] TextMeshProUGUI timerText;
//    float elapsedTime;

//    // Update is called once per frame
//    void Update()
//    {
//        elapsedTime += Time.deltaTime;
//        int minutes = Mathf.FloorToInt(elapsedTime / 60);
//        int seconds = Mathf.FloorToInt(elapsedTime % 60);
//        timerText.text = string.Format("{00:00}:{1:00}",minutes,seconds);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] AudioSource backgroundAudio;
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            TriggerGameOver();

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);
    }

    void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        backgroundAudio.Play();
    }
}