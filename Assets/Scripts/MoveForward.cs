using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private GameManager gameManager;

    public float speed = 4;
    //private float backBound = -30;
    private Vector3 startPos;
    //private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            //objectRb.AddForce(Vector3.back * speed);
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (transform.position.z < -30)
        {
            Destroy(gameObject);

        }
    }
    
}
