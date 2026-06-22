using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class TitleScreen : MonoBehaviour
{
    [Tooltip("El número de tu escena de Menú en los Build Settings")]
    public int mainMenuSceneIndex = 1;

    void Start()
    {
        // Si regresamos de una partida, reactivamos la música del menú
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlaySound("MenuTheme");
        }
    }

    void Update()
    {
        // Detecta si se presiona la tecla Enter normal o el Enter del teclado numérico
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            LoadMenu();
        }
    }

    void LoadMenu()
    {
        // Opcional: Si quieres que suene algo al pulsar Enter, descomenta la siguiente línea
        // AudioManager.instance.PlaySound("Click");

        // Carga la escena del menú principal
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
}