using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gamehasEnded == true)
        {
            return;
        }
        if (transform.position.x < -2.95f)
        {
            transform.position = new Vector3(2.8f, transform.position.y, transform.position.z);
        }
        //if(GameController.instance.gamehasEnded == true)
        //{
        //    transform.Translate(transform.position.x, transform.position.y, transform.position.z);

        //}
        //else
        //{
        //    
        //}
        transform.Translate(-2f * Time.deltaTime, 0, 0);


    }
}
