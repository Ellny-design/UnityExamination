using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Lore");
    }
    
    public void NextScene2()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void doExitGame() 
    {
        Application.Quit();
    }
}
