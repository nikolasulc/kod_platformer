using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPortal2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Provjeri je li objekt koji ulazi igrac
        if (other.CompareTag("Player"))
        {
            // Ucitaj Game Over scenu
            SceneManager.LoadScene("GameOver");
        }
    }
}
