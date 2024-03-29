﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeControler : MonoBehaviour{

    public float scrollspeed = 6.5f;
    bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (isGameOver) return;


        //Scrolling
        GameObject currentChild;
        for (int i = 0; i < transform.childCount; i++){
            currentChild = transform.GetChild(i).gameObject;
            ScrollChallenge(currentChild);
            if (currentChild.transform.position.x <= -15.0f) {
                Destroy(currentChild);

            }
        }

    }

    void ScrollChallenge(GameObject currentChallenge){
        currentChallenge.transform.position -= Vector3.left * (scrollspeed * Time.deltaTime);
    }

    public void GameOver() {
        isGameOver = true;
        transform.GetComponent<GameController>().GameOver();


    }
    public void SpeedX1()
    {
        scrollspeed = 6.5f;
    }


    public void SpeedX2()
    {
        scrollspeed = 10.0f;
    }

    
}
