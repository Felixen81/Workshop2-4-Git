using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    
    private void Update()
    {
        
    }

    public void SceneChange()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
