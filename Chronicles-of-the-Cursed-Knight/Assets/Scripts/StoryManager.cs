using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class StoryManager : MonoBehaviour
{
    [Header("Referencias Principales")]
    public VideoPlayer videoPlayer;
    public TextMeshProUGUI storyTextComponent;
    public CanvasGroup fadeCanvasGroup;

    [Header("Configuración de Audio")]
    [Tooltip("Nombre del objeto que trae la música desde el menú")]
    public string menuMusicObjectName = "AudioManager";
    [Tooltip("Arrastra aquí el AudioSource si quieres poner música nueva para la historia")]
    public AudioSource cinematicMusic;

    [Header("Contenido (Videos y Textos)")]
    public VideoClip[] videoClips;
    [TextArea(3, 5)]
    public string[] storyTexts;

    [Header("Configuración de Tiempos")]
    public float typingSpeed = 0.05f;
    public float fadeDuration = 1.0f;
    public string nextSceneName = "SampleScene";

    private int currentIndex = 0;
    private bool isTyping = false;
    private bool isEnding = false;
    private bool isTransitioning = false;
    private Coroutine typingCoroutine;

    void Start()
    {
        AudioManager[] audioManagersInvasores = FindObjectsOfType<AudioManager>();

        foreach (AudioManager manager in audioManagersInvasores)
        {
            AudioSource[] todosLosAudios = manager.GetComponentsInChildren<AudioSource>();
            foreach (AudioSource audio in todosLosAudios)
            {
                audio.Stop();
            }

            Destroy(manager.gameObject);
        }

        if (cinematicMusic != null) cinematicMusic.Play();

        if (videoClips.Length > 0)
        {
            videoPlayer.loopPointReached += OnVideoEnded;

            if (fadeCanvasGroup != null) fadeCanvasGroup.alpha = 1f;
            StartCoroutine(TransitionToNextSlide(true));
        }
    }

    void Update()
    {
        if (isEnding || isTransitioning) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            if (isTyping)
            {
                if (typingCoroutine != null) StopCoroutine(typingCoroutine);
                storyTextComponent.text = storyTexts[currentIndex];
                isTyping = false;
            }
            else
            {
                NextSlide();
            }
        }
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        NextSlide();
    }

    void NextSlide()
    {
        if (isEnding || isTransitioning) return;

        currentIndex++;

        if (currentIndex < videoClips.Length)
        {
            StartCoroutine(TransitionToNextSlide(false));
        }
        else
        {
            StartFinalFade();
        }
    }

    private IEnumerator TransitionToNextSlide(bool isFirstVideo)
    {
        isTransitioning = true;
        if (typingCoroutine != null) StopCoroutine(typingCoroutine);

        if (!isFirstVideo && fadeCanvasGroup != null)
        {
            LeanTween.alphaCanvas(fadeCanvasGroup, 1f, fadeDuration / 2f).setEase(LeanTweenType.easeInQuad);
            yield return new WaitForSeconds(fadeDuration / 2f);
        }

        videoPlayer.clip = videoClips[currentIndex];
        storyTextComponent.text = "";

        videoPlayer.Prepare();

        while (!videoPlayer.isPrepared)
        {
            yield return null;
        }

        videoPlayer.Play();

        if (fadeCanvasGroup != null)
        {
            LeanTween.alphaCanvas(fadeCanvasGroup, 0f, fadeDuration / 2f).setEase(LeanTweenType.easeOutQuad);
            yield return new WaitForSeconds(fadeDuration / 2f);
        }

        if (currentIndex < storyTexts.Length)
        {
            typingCoroutine = StartCoroutine(TypewriterEffect(storyTexts[currentIndex]));
        }

        isTransitioning = false;
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