using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ---------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    public AudioSource audioSource;

    [Header("---------- Audio Clip ---------------")]
    public AudioClip background;
    public AudioClip backgroundLoop;
    public AudioClip go321;

    private bool ison;
    private void Start()
    {
        musicSource.clip = go321;
        
        if (ManagerAudio.Instance != null)
        {
            bool musicState = ManagerAudio.Instance.isOn;
            ison = musicState;
            Debug.Log("Music State: " + musicState);
            Destroy(ManagerAudio.Instance.gameObject);
            SceneManager.UnloadSceneAsync("MainMenu");
        }
        if (ison)
        {
            musicSource.Play();
        } 
        else
        {
            musicSource.Pause();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        //SFXSource.PlayOneShot(clip);
        audioSource.clip = clip;
        if (ison)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
        
    }

    public bool IsPlaying(AudioClip clip)
    {
        return audioSource.isPlaying && audioSource.clip == clip;
    }

    public void SetLoop(bool shouldLoop)
    {
        audioSource.loop = shouldLoop;
    }
}
