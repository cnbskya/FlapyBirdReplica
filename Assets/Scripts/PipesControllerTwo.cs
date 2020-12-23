using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesControllerTwo : MonoBehaviour
{
    public float yAltSinir = -4.81f;
    public float yUstSinir = 0.78f;

    GameController gameControllers;
    public static PipesController instances;
    float randomNumbers;

    void Start()
    {
        //instances = this;
        gameControllers = GameObject.Find("GameController").GetComponent<GameController>();
        float randomNumber = Random.Range(-4.81f, -0.78f);
        transform.position = new Vector3(4f, randomNumber, transform.position.z);
    }

    
    void Update()
    {
        if (GameController.instance.gamehasEnded == true)
        {
            return;
        }
        //
        if (transform.position.x < -3.81f)
        {
            gameControllers.ScoreIncrement(1);
            transform.position = transform.position + new Vector3(7.5f, randomNumbers, 0);
        }
        transform.Translate(-2f * Time.deltaTime, 0, 0);

    }
}
