using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject pipes;
    public GameObject pipesTwo;
    private int score = 0;
    public Text scoreText;
    public Text LastScore;
    public bool gamehasEnded = false;
    public GameObject comleteLevelUI;
    public AudioClip[] soundFiles;

    public void CompleteLevel() // PREFABA GAME CONTROLLERI VEREMİYORUM :/ ÇIKARTIP DENE 
    {
        Debug.Log("Complete Level");
        comleteLevelUI.SetActive(true);
        LastScore.text = scoreText.text;
    }

    public void EndGame()
    {
       
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("Game Over!");
            PlayFailSound();
        }
        
    }

    public void PlayWingSound()
    {
        GetComponent<AudioSource>().PlayOneShot(soundFiles[0], 1);
    }   

    public void PlayFailSound()
    {
        GetComponent<AudioSource>().PlayOneShot(soundFiles[1], 1);
    }
    void Start()
    {
        instance = this;
        Invoke("CreatePipes", 10f);
        scoreText.text = score.ToString();
    }
    void CreatePipes()
    {
         //GameObject newPipes = Instantiate(pipes);
         pipes.transform.position = transform.position + new Vector3(5f, 0, 0);  
    }

    public void ScoreIncrement(int number)
    {
        score += number;
        scoreText.text = score.ToString();
    }

}
