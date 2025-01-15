using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Za resetiranje scene
using UnityEngine.UI; // Za UI elemente

public class HealthBar : MonoBehaviour
{
    private RectTransform bar;
    private Image barImage;

    public float maxHealth = 1f; // Maksimalno zdravlje

    
    void Start()
    {
        // Resetiraj health na maksimalnu vrijednost pri pokretanju scene
        Health.totalHealth = maxHealth;

        bar = GetComponent<RectTransform>();
        barImage = GetComponent<Image>();

        UpdateHealthBar();
    }

    public void Damage(float damage)
    {
        // Smanji zdravlje
        Health.totalHealth -= damage;

        // Osiguraj da zdravlje ne ide ispod 0
        if (Health.totalHealth < 0f)
        {
            Health.totalHealth = 0f;
        }

        // Ažuriraj izgled health bara
        UpdateHealthBar();

        // Ako je zdravlje 0, resetiraj level
        if (Health.totalHealth == 0f)
        {
            ResetLevel();
        }
    }

    private void UpdateHealthBar()
    {
        // Postavi velicinu health bara
        SetSize(Health.totalHealth);

        // Promijeni boju ako je zdravlje nisko
        if (Health.totalHealth < 0.3f)
        {
            barImage.color = Color.red;
        }
        else
        {
            barImage.color = Color.green;
        }
    }

    public void SetSize(float size)
    {
        bar.localScale = new Vector3(size, 1f, 1f);
    }

    private void ResetLevel()
    {
        // Resetiraj trenutnu scenu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
