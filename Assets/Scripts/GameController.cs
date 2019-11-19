using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject gameOverPanel;
    public GameObject scoreGameObject;
    int score = 0;
    public Text bestText;
    public Text currentText;
    public GameObject newAlert;
    public Scene SceneToRestart;

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

        if(score > PlayerPrefs.GetInt("Best", 0))
        {
            PlayerPrefs.SetInt("Best", score);

            newAlert.SetActive(true);
        }

        bestText.text = "Best Score : " + PlayerPrefs.GetInt("Best", 0).ToString();
        currentText.text = "Current Score : " + score.ToString();

        gameOverPanel.SetActive(true);

    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevelName);

    }

    public void CompleteRestart()
    {
        Application.LoadLevel(SceneToRestart.handle);
    }

    public void IncrementScore()
    {
        score++;
        scoreGameObject.GetComponent<Text>().text = score.ToString();

    }

}
