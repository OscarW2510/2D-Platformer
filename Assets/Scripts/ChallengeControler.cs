using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeControler : MonoBehaviour{

    public float scrollspeed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

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


}
