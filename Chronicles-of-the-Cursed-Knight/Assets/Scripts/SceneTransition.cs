using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [Header("Configuración visual")]
    public Image fadeOverlay; // El panel negro que tapará la pantalla
    public float fadeDuration = 1f; // Cuántos segundos dura el fundido

    [Header("Solo para el Cover Inicial")]
    public bool isCoverScreen = false; // Activa esto solo en la primera escena
    public int nextSceneIndex = 1; // La escena a la que irá al pulsar Enter

    private bool isTransitioning = false;

    void Start()
    {
        // Al entrar a la escena: Empezamos en negro y nos hacemos transparentes
        if (fadeOverlay != null)
        {
            fadeOverlay.gameObject.SetActive(true);
            fadeOverlay.color = new Color(0, 0, 0, 1); // Negro opaco
            
            // Animación de LeanTween para desvanecer el negro
            // AÑADIDO: .setDelay(0.5f) para darle tiempo al video de cargar sin que el jugador lo note
            LeanTween.alpha(fadeOverlay.rectTransform, 0f, fadeDuration).setDelay(1.0f).setIgnoreTimeScale(true).setOnComplete(() => 
            {
                // Desactivamos la imagen para que no bloquee tus clics en los botones
                fadeOverlay.gameObject.SetActive(false); 
            });
        }
    }

    void Update()
    {
        // Si esta es la pantalla del Cover y presionamos Enter
        if (isCoverScreen && !isTransitioning)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                StartTransition(nextSceneIndex);
            }
        }
    }

    // Llama a esta función desde los botones (Play, Exit, etc.)
    public void StartTransition(int sceneIndex)
    {
        if (fadeOverlay != null && !isTransitioning)
        {
            isTransitioning = true;
            fadeOverlay.gameObject.SetActive(true);

            // Animación de LeanTween para oscurecer la pantalla
            // AÑADIDO: setIgnoreTimeScale(true) para evitar cuelgues al salir
            LeanTween.alpha(fadeOverlay.rectTransform, 1f, fadeDuration)
                .setIgnoreTimeScale(true)
                .setOnComplete(() =>
                {
                    // Una vez que está todo negro, cargamos la siguiente escena
                    SceneManager.LoadScene(sceneIndex);
                });
        }
    }
}