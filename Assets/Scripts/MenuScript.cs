using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script de l'écran titre
/// </summary>
public class MenuScript : MonoBehaviour
{
    public void PlayScene()
    {
        // Sur le clic, on démarre le premier niveau
        // "MainScene" est le nom de la première scène que nous avons créés.
        SceneManager.LoadScene("MainScene");

    }

    public void QuitScene()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}