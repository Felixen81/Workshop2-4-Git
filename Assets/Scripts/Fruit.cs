using System;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    
    public AudioClip audioSource;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audioSource, transform.position);
        }
        
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
