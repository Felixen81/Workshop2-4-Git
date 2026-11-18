using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    [SerializeField] private string getSceneName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene(getSceneName);
    }
}
