using UnityEngine;
using UnityEngine.EventSystems; 

public class PlayerDash : MonoBehaviour {

    [Header("Configuración del Dash")]
    public float dashForce = 15f;
    public float dashDuration = 0.2f;
    
    [Tooltip("¿Cuántos dashes seguidos puede hacer en el aire?")]
    public int maxAirDashes = 2; 

    private Rigidbody2D rb;
    private Animator animator;
    private Player player;
    private bool isDashing;
    private float originalGravity;
    private bool facingRight = true;
    
    private int currentDashes; 

    private const string ANIM_DASH = "Dash";
    private const string SOUND_DASH = "Dash";

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        originalGravity = rb.gravityScale;
        animator = this.GetComponent<Animator>();
        player = this.gameObject.GetComponent<Player>();
        currentDashes = maxAirDashes; 
    }

    // --- NUEVA FUNCIÓN DE SEGURIDAD ---
    public void CancelDash() {
        StopAllCoroutines(); // Detiene cualquier Dash en curso
        isDashing = false;
        rb.gravityScale = originalGravity; // Restaura gravedad
        animator.SetBool(ANIM_DASH, false); // Apaga animación
    }

    void Update() {
        if (Time.timeScale == 0f) return;

        if (player.isGround) {
            currentDashes = maxAirDashes;
        }

        float move = Input.GetAxisRaw("Horizontal");
        if (move > 0) facingRight = true;
        else if (move < 0) facingRight = false;

        if ((Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Backspace)) && !isDashing) {
            if (Input.GetMouseButtonDown(1) && EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) {
                return; 
            }

            if (!player.isGround && currentDashes > 0) {
                currentDashes--; 
                StartCoroutine(Dash());
            }
        }
    }

    System.Collections.IEnumerator Dash() {
        isDashing = true; 
        animator.SetBool(ANIM_DASH, true); 
        AudioManager.instance.PlaySound(SOUND_DASH);

        rb.gravityScale = 0f;
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); 
        
        float dashDir = facingRight ? 1f : -1f;
        rb.linearVelocity = new Vector2(dashDir * dashForce, 0f);

        yield return new WaitForSeconds(dashDuration);

        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = originalGravity;
        animator.SetBool(ANIM_DASH, false); 
        isDashing = false;
    }
}