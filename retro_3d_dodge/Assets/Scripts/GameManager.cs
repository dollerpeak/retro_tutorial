using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    float surviceTime;
    bool gameover;

    void Start()
    {
        surviceTime = 0f;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == false)
        {
            surviceTime += Time.deltaTime;
            surviceTime = (float)Math.Round(surviceTime, 2);

            timeText.text = "Time : " + surviceTime.ToString();
        }
        else
        {
            if (Input.anyKeyDown == true)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        gameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BEST_TIME");

        if (bestTime <= surviceTime)
        {
            bestTime = surviceTime;
            PlayerPrefs.SetFloat("BEST_TIME", bestTime);
        }

        recordText.text = "Best Record : " + bestTime.ToString();
    }
}
