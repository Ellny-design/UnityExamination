using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void doExitGame() 
    {
        Application.Quit();
    }
}
