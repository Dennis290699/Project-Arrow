using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
// DentedPixel ya está incluido si tienes LeanTween importado

public class StoryManager : MonoBehaviour
{
    [Header("Referencias Principales")]
    public VideoPlayer videoPlayer;
    public TextMeshProUGUI storyTextComponent;
    public CanvasGroup fadeCanvasGroup; // Usaremos esto para el fundido a negro

    [Header("Contenido (Videos y Textos)")]
    [Tooltip("Pon aquí tus videos en orden")]
    public VideoClip[] videoClips;

    [Tooltip("Pon aquí los textos que acompañan a cada video")]
    [TextArea(3, 5)]
    public string[] storyTexts;

    [Header("Configuración de Tiempos")]
    public float typingSpeed = 0.05f;
    public float fadeDuration = 1.0f;
    public string nextSceneName = "SampleScene";

    private int currentIndex = 0;
    private bool isTyping = false;
    private bool isEnding = false;
    private Coroutine typingCoroutine;

    void Start()
    {
        // 1. Empezamos con la pantalla totalmente negra y hacemos un Fade In suave
        if (fadeCanvasGroup != null)
        {
            fadeCanvasGroup.alpha = 1f;
            LeanTween.alphaCanvas(fadeCanvasGroup, 0f, fadeDuration).setEase(LeanTweenType.easeOutQuad);
        }

        // 2. Iniciamos el primer video
        if (videoClips.Length > 0)
        {
            videoPlayer.loopPointReached += OnVideoEnded;
            PlayCurrentSlide();
        }
    }

    void Update()
    {
        if (isEnding) return;

        // Sistema de "Skip" (Saltar) que ya tenías creado
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            if (isTyping)
            {
                // Si se está escribiendo, lo autocompletamos de golpe
                if (typingCoroutine != null) StopCoroutine(typingCoroutine);
                storyTextComponent.text = storyTexts[currentIndex];
                isTyping = false;
            }
            else
            {
                // Si ya se escribió todo el texto, saltamos inmediatamente al siguiente video
                NextSlide();
            }
        }
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        // Si el video termina de forma natural, pasamos al siguiente
        NextSlide();
    }

    void NextSlide()
    {
        if (isEnding) return;

        currentIndex++;

        if (currentIndex < videoClips.Length)
        {
            PlayCurrentSlide();
        }
        else
        {
            // Si ya se acabaron los videos, iniciamos la salida
            StartFinalFade();
        }
    }

    void PlayCurrentSlide()
    {
        // Reproducir el video correspondiente
        videoPlayer.clip = videoClips[currentIndex];
        videoPlayer.Play();

        // Limpiar el texto e iniciar el efecto de máquina de escribir
        if (currentIndex < storyTexts.Length)
        {
            if (typingCoroutine != null) StopCoroutine(typingCoroutine);
            typingCoroutine = StartCoroutine(TypewriterEffect(storyTexts[currentIndex]));
        }
        else
        {
            storyTextComponent.text = "";
        }
    }

    private IEnumerator TypewriterEffect(string textToType)
    {
        isTyping = true;
        storyTextComponent.text = "";

        foreach (char c in textToType)
        {
            storyTextComponent.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }

    void StartFinalFade()
    {
        isEnding = true;
        if (typingCoroutine != null) StopCoroutine(typingCoroutine);

        if (fadeCanvasGroup != null)
        {
            // Fade Out suave a negro usando el CanvasGroup que ya tenías
            LeanTween.alphaCanvas(fadeCanvasGroup, 1f, fadeDuration)
                .setEase(LeanTweenType.easeInQuad)
                .setOnComplete(() => {
                    SceneManager.LoadScene(nextSceneName);
                });
        }
        else
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}