using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float yAltSinir = -4.81f;
    public float yUstSinir = 0.78f;

    GameController gameController;
    public static PipesController instance;
    float randomNumber;

    void Start()
    {
        instance = this;
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        float randomNumber = Random.Range(-4.81f, -0.78f);
        transform.position = new Vector3(7.5f, randomNumber, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gamehasEnded == true)
        {
            return;
        }
        //
        if (transform.position.x < -3.81f)
        {
            gameController.ScoreIncrement(1);
            transform.position = transform.position + new Vector3(7.5f, randomNumber, 0);
        }
        transform.Translate(-2f * Time.deltaTime, 0, 0);
        
    }

    //public static implicit operator PipesController(PipesControllerTwo v)
    //{
    //    throw new System.NotImplementedException();
    //}
}
