using UnityEngine;

public class CheckpointElara : MonoBehaviour
{
    private Animator animator;
    private bool isActivated = false;

    [Header("Efecto de Sonido")]
    [Tooltip("Nombre de la pista de audio en el AudioManager")]
    public string activationSound = "checkpoint.wav"; 

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Validamos si la colisión pertenece al jugador y si la estatua no ha sido encendida aún
        if (other.CompareTag("Player") && !isActivated)
        {
            ActivateCheckpoint();
        }
    }

    void ActivateCheckpoint()
    {
        isActivated = true;
        
        // Enviamos la señal al Animator para pasar al bucle de brillo constante
        animator.SetBool("IsActive", true);

        // Reproducimos la retroalimentación auditiva de activación
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PlaySound(activationSound);
        }

        Debug.Log("¡Punto de control de Elara activado con éxito!");
    }
}