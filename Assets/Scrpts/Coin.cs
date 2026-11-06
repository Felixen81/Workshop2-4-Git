using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    
    
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        
            Destroy(gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
