using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] float jumpforce;
    Rigidbody2D rb;
    [SerializeField] ParticleSystem particle;
    void Start()
    {
        particle.Play();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(horizontal * movespeed * Time.deltaTime, 0, 0);
        
        

    }

    public void playerjump()
    {
        rb.AddForce(Vector2.up * jumpforce);
    }

}
