using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;
    private AudioSource playerAudio;
    //Public Variable
    public GameObject projectilePrefab;
    public ParticleSystem explosionGameOver;
    public AudioClip projectileSoundFX;
    public AudioClip destroyObstacleFX;
    public AudioClip crashFX;
    public float speed = 5.0f;
    public float xRange = 20;
    public bool gameOver = false;
    //Private Variables
    private float horizontalInput;
    private Rigidbody playerRb;
    

   
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //playerAudio.PlayOneShot(projectileSoundFX, 1.0f);
        }
    }

    private void MovePlayer()
    {
        //Get Player Input
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Player Forward
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Keep player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Altitude of Player
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup")) 
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //playerAudio.PlayOneShot(crashFX, 1.0f);
            gameOver = true;
            
            Instantiate(explosionGameOver, transform.position, explosionGameOver.transform.rotation);
            gameManager.GameOver();
            
            Debug.Log("GAME OVER!");
        }

    }
}

