using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
    //[SerializeField] AudioSource musicSrc;
    //[SerializeField] AudioSource SFXSrc;

    //[Header("---------- Audio Clip ---------------")]
    //public AudioClip background;
    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
    //private void Start()
    //{
    //    musicSrc.clip = background;
        
    //}
    public void OpenLevel(int levelId)
    {
        string levelName = "Level " + levelId;
        //musicSrc.Pause();
        SceneManager.LoadScene(levelName);
    }
}
