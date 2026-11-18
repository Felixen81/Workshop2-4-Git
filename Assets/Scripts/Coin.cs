using System;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public CoinManager coinManager;
    public int value;
    public AudioClip audioSource;
    public ParticleSystem particleSystem;
    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        coinManager.ChangeCoins(value);
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audioSource, transform.position);
            particleSystem.transform.parent = null;
            particleSystem.Play();


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
