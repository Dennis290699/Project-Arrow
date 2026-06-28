using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndTransition : MonoBehaviour
{
    [Header("Configuración")]
    public VideoPlayer miVideo;
    public GameObject textoPressEnter;
    public string escenaDestino = "Menu";

    private bool videoTerminado = false;

    void Start()
    {
        // Nos aseguramos de que el texto empiece apagado
        if (textoPressEnter != null)
        {
            textoPressEnter.SetActive(false);
        }

        // Le decimos al VideoPlayer que nos avise al terminar
        if (miVideo != null)
        {
            miVideo.loopPointReached += MostrarTexto;
        }
    }

    void MostrarTexto(VideoPlayer vp)
    {
        // El video terminó, encendemos la variable y mostramos el texto
        videoTerminado = true;
        if (textoPressEnter != null)
        {
            textoPressEnter.SetActive(true);
        }
    }

    void Update()
    {
        // Si el video ya terminó Y el jugador presiona Enter (o hace clic)
        if (videoTerminado && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0)))
        {
            SceneManager.LoadScene(escenaDestino);
        }
    }
}