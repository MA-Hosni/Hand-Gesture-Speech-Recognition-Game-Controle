using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public AudioClip loopClip;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        audioManager.PlaySFX(audioManager.background);
        StartCoroutine(PlayLoopAfterBackground());
    }

    IEnumerator PlayLoopAfterBackground()
    {
        // Wait until the background clip finishes playing
        yield return new WaitUntil(() => !audioManager.IsPlaying(audioManager.background));

        // Play the looped clip and set it to loop
        audioManager.PlaySFX(loopClip);
        audioManager.SetLoop(true);
    }

    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
