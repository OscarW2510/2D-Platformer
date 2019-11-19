using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScripts : MonoBehaviour{

    public float jumpPower = 10.0f;
    Rigidbody2D myRigidbody;
    public bool isGrounded = false;
    float posX = 0.0f;
    bool isGameOver = false;
    ChallengeControler myChallengeController;
    GameController myGameController;

    // Start is called before the first frame update
    void Start(){
        myRigidbody = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
        myChallengeController = GameObject.FindObjectOfType<ChallengeControler>();
        myGameController = GameObject.FindObjectOfType<GameController>();
    }

   
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.Space) && isGrounded && !isGameOver) {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 20.0f));
        }
      
        
    }

    void Update(){

    } 
    void GameOver(){
        isGameOver = true;
        myChallengeController.GameOver();
    }

    void OnCollisionEnter2D(Collision2D other){

        if (other.collider.tag == "Ground") {
            isGrounded = true;
        }
        if(other.collider.tag == "KillTrigger")
        {
            isGameOver = true;
            myChallengeController.GameOver();
        }

    }

    void OnCollisionStay2D(Collision2D other)
    {

        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {

        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Star")
        {
            myGameController.IncrementScore();
            Destroy(other.gameObject);

        }


        else if (other.tag == "LevelComplete") 
        {
            SceneManager.LoadScene(2);
        }
        
    }

}
