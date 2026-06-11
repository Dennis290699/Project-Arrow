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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu() {
        PlayClickSound();
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame() {
        PlayClickSound();
        Application.Quit();
    }

    public void HomeScreen() {
        PlayClickSound();
        SceneManager.LoadScene("MainMenu");
    }
}