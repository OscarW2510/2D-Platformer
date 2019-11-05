using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    public GameObject gameOverPanel;
    public GameObject scoreGameObject;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void GameOver()
    {
        Invoke("ShowOverPanel", 2.0f);

    }

    void ShowOverPanel()
    {
        scoreGameObject.SetActive(false);
        gameOverPanel.SetActive(true);

    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevelName);

    }

    public void IncrementScore()
    {
        score++;
        scoreGameObject.GetComponent<Text>().text = score.ToString();

    }

}
