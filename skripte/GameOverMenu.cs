using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Metoda za ponovni povratak na Main Menu
    public void MainMenu()
    {
        // Ucitaj scenu Main Menu
        SceneManager.LoadScene("MainMenu");
    }

    // Metoda za izlazak iz igre
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // Provjera u Unity Editoru
        Application.Quit();     // Zatvori igru
    }
}
