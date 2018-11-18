using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script de l'écran titre
/// </summary>
public class MenuScript : MonoBehaviour
{
    private GameObject pancarte;
    private GameObject PlayBtn;
    private GameObject HelpBtn;

    private void Start()
    {
        pancarte = GameObject.Find("Canvas").transform.GetChild(3).gameObject;
        PlayBtn = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
        HelpBtn = GameObject.Find("Canvas").transform.GetChild(2).gameObject;
        pancarte.SetActive(false);
        PlayBtn.SetActive(true);
        HelpBtn.SetActive(true);
    }
    public void PlayScene()
    {
        // Sur le clic, on démarre le premier niveau
        // "MainScene" est le nom de la première scène que nous avons créés.
        SceneManager.LoadScene("GameScene_Aymeric");

    }

    public void OnClick() {
        pancarte.SetActive(true);
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

    public void ActivePancarte(){
        pancarte.SetActive(true);
        PlayBtn.SetActive(false);
        HelpBtn.SetActive(false);
    }

    public void DesActivePancarte()
    {
        pancarte.SetActive(false);
        PlayBtn.SetActive(true);
        HelpBtn.SetActive(true);
    }
}