using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // za pokretanje igre
    public void PlayGame()
    {
        // Ucitava igru
        SceneManager.LoadScene("Level 1");
    }

    // za gasenje igre
    public void QuitGame()
    {
        Debug.Log("Quit Game"); 
        Application.Quit();
    }
}
