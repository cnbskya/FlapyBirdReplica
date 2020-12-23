using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    // 0.32 11.21
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
        if (transform.position.x <= -8.13f)
        {
            transform.position = new Vector3(-2.93f, transform.position.y, transform.position.z);
        }

        transform.Translate(-0.5f * Time.deltaTime, 0, 0);
    }
}
