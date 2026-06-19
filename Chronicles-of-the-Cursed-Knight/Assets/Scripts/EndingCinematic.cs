using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VideoPlayer))]
public class EndingCinematic : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    [Header("Configuración")]
    [Tooltip("Nombre de la escena a la que irá al terminar (ej: Menu o MainMenu)")]
    public string nextSceneName = "Menu";

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Nos suscribimos al evento mágico de Unity que avisa cuando un video termina
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // El video terminó, cargamos la siguiente escena.
        // Aquí podrías llamar a tu SceneTransition si quieres un fundido a negro.
        SceneManager.LoadScene(nextSceneName);
    }
}