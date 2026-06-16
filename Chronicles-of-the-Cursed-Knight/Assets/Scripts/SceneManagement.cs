using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {
    public static SceneManagement instance;

    public void PlayClickSound() {
        AudioManager.instance.PlaySound("Click");
    }

    private void Awake() {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void PlayGame() {
        PlayClickSound();
        // AHORA CARGAMOS LA ESCENA DE LA HISTORIA, NO EL JUEGO DIRECTO
        SceneManager.LoadScene("StoryScene"); 
    }

    public void Retry() {
        PlayClickSound();
        if (AudioManager.instance != null)
        {
            AudioManager.instance.StopSound("Game Over");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu() {
        PlayClickSound();

        if (AudioManager.instance != null)
        {
            AudioManager.instance.StopSound("GameTheme");
            AudioManager.instance.StopSound("CreditsTheme");
            AudioManager.instance.StopSound("Game Over");

            AudioManager.instance.PlaySound("MenuTheme");
        }

        SceneManager.LoadScene("Menu");
    }

    public void ExitGame() {
        PlayClickSound();
        Application.Quit();
    }

    public void HomeScreen()
    {
        PlayClickSound();

        if (AudioManager.instance != null)
        {
            AudioManager.instance.StopSound("GameTheme");
            AudioManager.instance.StopSound("Game Over");
            AudioManager.instance.StopSound("CreditsTheme");
            AudioManager.instance.PlaySound("MenuTheme");
        }

        SceneManager.LoadScene("MainMenu");
    }

    public void OpenCreditsPanel()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.StopSound("MenuTheme");
            AudioManager.instance.PlaySound("CreditsTheme");
        }
    }

    public void CloseCreditsPanel()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.StopSound("CreditsTheme");
            AudioManager.instance.PlaySound("MenuTheme");
        }
    }
}