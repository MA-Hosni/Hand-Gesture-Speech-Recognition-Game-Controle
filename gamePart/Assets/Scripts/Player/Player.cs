using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] AudioSource backgroundAudio;
    public float playerSpeed;
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 playerDirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxis("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    animator.SetTrigger("Slide");
        //    animator.SetBool("isSliding", true);
        //    animator.SetBool("isSliding", false);
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    animator.SetTrigger("Disappear");

        //    animator.SetTrigger("Appear");
        //}

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    //private void OnBecameInvisible()
    //{
    //    gameOverPanel.SetActive(true);
    //    Time.timeScale = 0;
    //}
}
