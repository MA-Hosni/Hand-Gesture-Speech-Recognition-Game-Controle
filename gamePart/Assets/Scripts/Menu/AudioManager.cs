using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI; // Import UI namespace

public class ManagerAudio : MonoBehaviour
{
    public static ManagerAudio Instance { get; private set; }
    public bool isOn;
    [SerializeField] AudioSource musicSrc;
    [SerializeField] AudioSource SFXSrc;

    [Header("---------- Audio Clip ---------------")]
    public AudioClip background;

    [Header("---------- UI Buttons ---------------")]
    public GameObject musicOnButton;
    public GameObject musicOffButton;
    public GameObject soundOnButton;
    public GameObject soundOffButton;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }

    private void Start()
    {
        musicSrc.clip = background;
        musicSrc.Play();

        musicOnButton.SetActive(true);
        musicOffButton.SetActive(false);
        soundOnButton.SetActive(true);
        soundOffButton.SetActive(false);
        isOn = true;
    }

    public void ToggleMusic()
    {
        if (!musicOnButton.activeSelf)
        {
            musicSrc.Pause();
        }
        else
        {
            musicSrc.Play();
        }
        isOn = musicOnButton.activeSelf;
    }
}