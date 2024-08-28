using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    public float speed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = yInput * speed;
        
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidBody.velocity = newVelocity;
    }   
    
    public void Die(){
        gameObject.SetActive(false);
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
