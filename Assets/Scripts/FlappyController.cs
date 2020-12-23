using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float bendingSpeed;
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
            GameController.instance.EndGame();   
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero; // eğer space tuşuna basıldığında mevcut bir kuvvet varsa sıfırlıyoruz.
            rb.AddForce(Vector2.up * jumpForce , ForceMode2D.Impulse); // Ardından kuvvetimizi biz uyguluyoruz.
            GameController.instance.PlayWingSound();
            // Vector3 türünde bir açı değeri girmemi sağlıyor.
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);
        }
        else
        {
            // kuvvet vermeyi bıraktığımızda belirli bir süre içerisinde azalacağı açı değeri
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, bendingSpeed);
        }
    }

}
