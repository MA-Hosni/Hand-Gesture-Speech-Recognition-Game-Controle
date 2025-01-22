using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDestroyer : MonoBehaviour
{
    private GameObject player;
    private Animator playerAnimator;
    private bool isPlayerInWater = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerAnimator = player.GetComponent<Animator>();
    }

    void Update()
    {
        // Check for key press and handle animation logic if the player is in the water zone
        if (isPlayerInWater && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(HandlePlayerDisappearAndAppear());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed");
        }
        else if (collision.tag == "Player")
        {
            isPlayerInWater = true; // Set flag when the player enters the water zone
            Debug.Log("Player entered water zone");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPlayerInWater = false; // Reset flag when the player exits the water zone
            Debug.Log("Player exited water zone");
        }
    }

    private IEnumerator HandlePlayerDisappearAndAppear()
    {
        //playerAnimator.SetTrigger("Disappear"); // Trigger disappear animation
        //player.SetActive(false);
        //// Wait for 4 seconds
        //yield return new WaitForSeconds(3.6f);
        //player.SetActive(true);
        //playerAnimator.SetTrigger("Appear"); // Trigger appear animation
//###############################################################################
        //playerAnimator.SetTrigger("Disappear"); // Trigger disappear animation

        //// Wait for the disappear animation to complete
        //float disappearAnimationLength = playerAnimator.GetCurrentAnimatorStateInfo(0).length;
        //yield return new WaitForSeconds(disappearAnimationLength);

        //player.SetActive(false);

        //// Wait for 3 seconds
        //yield return new WaitForSeconds(3f);

        //player.SetActive(true);
        //yield return new WaitForSeconds(0.1f); // Small delay to reset Animator
        //playerAnimator.SetTrigger("Appear"); // Trigger appear animation
        //Debug.Log("Appear trigger set");

        //// Wait for the appear animation to complete
        //float appearAnimationLength = playerAnimator.GetCurrentAnimatorStateInfo(0).length;
        //yield return new WaitForSeconds(appearAnimationLength);

        //######################################################################################


            playerAnimator.SetTrigger("Disappear"); // Trigger disappear animation

            // Wait for the disappear animation to complete
            float disappearAnimationLength = playerAnimator.GetCurrentAnimatorStateInfo(0).length;
            yield return new WaitForSeconds(disappearAnimationLength);

            player.SetActive(false);

            // Wait for 3 seconds
            yield return new WaitForSeconds(3f);

            // Set the animator to "Appear" state immediately
            player.SetActive(true);
            playerAnimator.Play("Player_Appear", 0, 0); // Play the "Appear" animation directly
            yield return null; // Allow one frame for activation

            Debug.Log("Appear trigger set"); // Add this line

            // Wait for the appear animation to complete
            float appearAnimationLength = playerAnimator.GetCurrentAnimatorStateInfo(0).length;
            yield return new WaitForSeconds(appearAnimationLength);

    }
}
