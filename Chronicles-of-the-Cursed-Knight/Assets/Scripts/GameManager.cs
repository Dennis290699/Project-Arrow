using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para el botón de ir al menú

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [Header("Game Over UI")]
    [SerializeField] private GameObject gameOverUIBG;

    [Header("Victory UI")]
    [SerializeField] private GameObject victoryUIBG;

    [Header("Pause UI")]
    [SerializeField] private GameObject pauseUIBG; 

    public int key;

    // Variables para controlar el estado de la pausa
    private bool isPaused = false;
    private bool isTransitioning = false; // Evita que se rompa si pulsas 'P' muy rápido

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }

    private void Start() {
        key = 0;

        // Escondemos los menús moviéndolos hacia abajo (-1200) al iniciar
        if (gameOverUIBG != null) gameOverUIBG.transform.localPosition = new Vector3(0f, -1200f, 0f);
        if (pauseUIBG != null) pauseUIBG.transform.localPosition = new Vector3(0f, -1200f, 0f);
    }

    private void Update() {
        // Detectar tecla 'P' para pausar/reanudar
        if (Input.GetKeyDown(KeyCode.P) && !isTransitioning) {
            if (isPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }
    }

    public void TriggerGameOverUI() {
        AudioManager.instance.PlaySound("Game Over");
        gameOverUIBG.LeanMoveLocalY(0f, .8f).setEaseOutBounce();
    }

    public void TriggerVictoryUI() {
        victoryUIBG.LeanMoveLocalY(0f, .8f).setEaseInOutBack();
    }

    // --- LÓGICA DE PAUSA ---

    public void PauseGame() {
        isPaused = true;
        isTransitioning = true;
        
        if (pauseUIBG != null) {
            // Sube el BG al centro de la pantalla, ignorando que el tiempo se va a detener
            pauseUIBG.LeanMoveLocalY(0f, 0.6f)
                .setIgnoreTimeScale(true)
                .setEaseOutBounce()
                .setOnComplete(() => isTransitioning = false);
        }
        
        Time.timeScale = 0f; // Congela el juego
    }

    public void ResumeGame() {
        isTransitioning = true;
        
        if (pauseUIBG != null) {
            // Baja el BG de vuelta a -1200
            pauseUIBG.LeanMoveLocalY(-1200f, 0.5f)
                .setIgnoreTimeScale(true)
                .setEaseInBack()
                .setOnComplete(() => {
                    // Solo cuando termina la animación, reactivamos el juego
                    isPaused = false;
                    isTransitioning = false;
                    Time.timeScale = 1f; 
                });
        } else {
            isPaused = false;
            isTransitioning = false;
            Time.timeScale = 1f;
        }
    }

    // Función para el botón "Menu"
    public void GoToMenu() {
        Time.timeScale = 1f; // Descongelar antes de cambiar de escena
        SceneManager.LoadScene(1); 
    }
}