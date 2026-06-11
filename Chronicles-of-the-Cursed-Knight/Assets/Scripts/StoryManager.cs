using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using DentedPixel; // LeanTween

public class StoryManager : MonoBehaviour
{
    [Header("Referencias de UI")]
    public TextMeshProUGUI storyTextComponent;
    public CanvasGroup storyCanvasGroup;

    [Header("Configuración de Historia")]
    [TextArea(3, 10)]
    public string fullStoryText;
    public float typingSpeed = 0.05f;

    [Header("Configuración de Transiciones")]
    public float fadeDuration = 0.8f;
    public float delayAfterStory = 2.0f;

    private bool isTyping = false;
    private bool isStoryFinished = false;

    void Start()
    {
        // 1. Empezamos con la pantalla totalmente negra/transparente y el texto vacío
        storyCanvasGroup.alpha = 0f;
        storyTextComponent.text = "";
        
        // 2. Iniciamos la cinemática
        StartCoroutine(PlayStoryRoutine());
    }

    void Update()
    {
        // Sistema de "Skip" (Saltar) con Espacio, Enter o Clic izquierdo
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            if (isTyping)
            {
                // Si el texto se está escribiendo, lo autocompletamos de golpe
                StopAllCoroutines(); 
                storyTextComponent.text = fullStoryText;
                isTyping = false;
                StartCoroutine(EndStoryRoutine());
            }
            else if (isStoryFinished)
            {
                // Si ya terminó de escribirse y está en la pausa final, saltamos al juego
                StopAllCoroutines();
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    private IEnumerator PlayStoryRoutine()
    {
        // Fade In suave
        LeanTween.alphaCanvas(storyCanvasGroup, 1f, fadeDuration).setEase(LeanTweenType.easeOutQuad);
        yield return new WaitForSeconds(fadeDuration);

        // Efecto Máquina de Escribir
        isTyping = true;
        foreach (char c in fullStoryText)
        {
            storyTextComponent.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;

        // Iniciar la salida
        StartCoroutine(EndStoryRoutine());
    }

    private IEnumerator EndStoryRoutine()
    {
        isStoryFinished = true;
        
        // Pausa para que el jugador lea el texto completo
        yield return new WaitForSeconds(delayAfterStory);

        // Fade Out suave
        LeanTween.alphaCanvas(storyCanvasGroup, 0f, fadeDuration).setEase(LeanTweenType.easeInQuad);
        yield return new WaitForSeconds(fadeDuration);

        // Cargar el nivel
        SceneManager.LoadScene("SampleScene");
    }
}
