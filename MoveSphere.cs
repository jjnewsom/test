using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MoveSphere : MonoBehaviour
{
    public Rigidbody ball;
    public int speed;
    private float moveHorizontal;
    private float moveVertical;

    private int score = 0;
    public Text scoreText; 

    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        ball.AddForce(moveHorizontal * speed, 0, moveVertical * speed);
        scoreText.text = "Score: " + score.ToString(); 
    
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            score++; 
        }
        
    }
}
