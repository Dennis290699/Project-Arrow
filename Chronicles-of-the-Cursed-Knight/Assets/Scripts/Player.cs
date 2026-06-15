using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
using UnityEngine.EventSystems; // <-- LIBRERÍA NECESARIA PARA DETECTAR LA UI

public class Player : MonoBehaviour
{
    public static Player instance;
    public int maxHealth = 5;
    private Animator animator;
    public Rigidbody2D rb;
    public float jumpHeight = 7f;
    public float moveSpeed = 5f;

    private float movement;
    [HideInInspector] public bool isGround;
    private bool facingRight;

    public Transform groundCheckPoint;
    public float groundCheckRadius = .2f;
    public LayerMask whatIsGround;

    public GameObject arrowPrefab;
    public Transform spawnPosition;
    public float arrowSpeed = 7f;

    public GameObject explosionPrefab;
    public Transform explosionSpawnPoint;

    private int currentDiamonds;
    public GameObject collect_EffectPrefab;

    public Text currentHeart_Text;
    public Text currentDiamond_Text;

    private int jumpCount;
    public int totallJumps = 2;
    private bool isVictory;

    [Header("Inmunidad")]
    public float iFrameDuration = 1.5f;
    private bool isInvincible = false;

    private const string ANIM_RUN = "Run";
    private const string ANIM_JUMP = "Jump";
    private const string ANIM_HURT = "Hurt";
    private const string ANIM_FIRE = "Fire";
    private const string SOUND_DASH = "Dash";
    private const string SOUND_COLLECT = "Collect";
    private const string SOUND_EXPLOSION = "Explosion";

    void Start()
    {
        maxHealth = 5;
        isGround = true;
        facingRight = true;
        animator = this.gameObject.GetComponent<Animator>();

        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }

        currentDiamonds = 0;
        jumpCount = totallJumps;
        isVictory = false;

        UpdateUI();
    }

    void Update()
    {
        if (maxHealth <= 0) return;

        if (isVictory) {
            animator.SetFloat(ANIM_RUN, 0f);
            return;
        }

        // BARRERA 1: Si el tiempo está pausado, abortamos la lectura de controles aquí mismo
        if (Time.timeScale == 0f) return;

        movement = Input.GetAxis("Horizontal");

        Collider2D collInfo = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
        if (collInfo) {
            isGround = true;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }

        Flip();
        PlayRunAnimation();

        // BARRERA 2: Lógica de Disparo Protegida
        if (Input.GetMouseButtonDown(0)) {
            // Verificamos si el clic físico del ratón está tocando la UI
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) {
                // El clic fue en un botón o panel (como 'Continue'). Ignoramos el disparo.
            } else {
                // El clic fue en el mundo del juego. Disparamos normal.
                animator.SetTrigger(ANIM_FIRE);
            }
        }

        // --- Controles de prueba y debug ---
        if (Input.GetKeyDown(KeyCode.F1)) {
            Debug.Log("Prueba: Daño simulado (-1)");
            TakeDamage(1); 
        }

        if (Input.GetKeyDown(KeyCode.F2)) {
            Debug.Log("Prueba: Curación simulada (+1)");
            maxHealth++;
            UpdateUI(); 
        }

        if (Input.GetKeyDown(KeyCode.F3)) {
            Debug.Log("Prueba: Muerte instantánea");
            TakeDamage(maxHealth); 
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(movement * moveSpeed, 0f, 0f) * Time.fixedDeltaTime;
    }

    public void FireArrow() {
        GameObject tempArrowPrefab = Instantiate(arrowPrefab, spawnPosition.position, spawnPosition.rotation);
        tempArrowPrefab.GetComponent<Rigidbody2D>().linearVelocity = spawnPosition.right * arrowSpeed;
    }

    void PlayRunAnimation() { 
        if (Mathf.Abs(movement) > 0f) {
            animator.SetFloat(ANIM_RUN, 1f);
        }
        else if (Mathf.Abs(movement) < 0.1f) {
            animator.SetFloat(ANIM_RUN, 0f);
        }
    }

    void Flip() { 
        if (movement < 0f && facingRight) {
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
            facingRight = false;
        }
        else if (movement > 0f && !facingRight) {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            facingRight = true;
        }
    }

    void Jump() {
        if (isGround && jumpCount > 0) {
            Vector2 velocity = rb.linearVelocity;
            velocity.y = jumpHeight;
            rb.linearVelocity = velocity;
            isGround = false;
            animator.SetBool(ANIM_JUMP, true);
            AudioManager.instance.PlaySound(SOUND_DASH);
            jumpCount--;
        }
    }

    public void TakeDamage(int damageAmount) { 
        if (maxHealth <= 0 || isInvincible) return; 

        maxHealth -= damageAmount;
        UpdateUI(); 
        animator.SetTrigger(ANIM_HURT);
        CameraShake.instance.Shake(2f, .12f);

        if (maxHealth <= 0) {
            Die();
        } else {
            StartCoroutine(InvulnerabilityRoutine());
        }
    }

    private IEnumerator InvulnerabilityRoutine() {
        isInvincible = true;
        yield return new WaitForSeconds(iFrameDuration);
        isInvincible = false;
    }

    private void UpdateUI() {
        if(currentHeart_Text != null) currentHeart_Text.text = maxHealth.ToString();
        if(currentDiamond_Text != null) currentDiamond_Text.text = currentDiamonds.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            animator.SetBool(ANIM_JUMP, false);
            jumpCount = totallJumps;
        }
    }

private void OnTriggerEnter2D(Collider2D coll) {
        
        // --- INSTAKILL PRIORITARIO: El DeadLine siempre gana ---
        if (coll.gameObject.CompareTag("DeadLine")) {
            // 1. Cancelamos el Dash instantáneamente para recuperar la física normal
            PlayerDash dashScript = GetComponent<PlayerDash>();
            if (dashScript != null) {
                dashScript.CancelDash();
            }
            
            // 2. Ejecutamos la muerte directa sin pasar por TakeDamage
            // Esto evita que lógica de vida o inmunidad interfieran con el instakill
            Die(); 
            return; // Salimos de la función para no procesar nada más
        }

        // --- Lógica normal de otros objetos ---
        if (coll.gameObject.CompareTag("Trap")) {
            TakeDamage(1);
        }

        if (coll.gameObject.CompareTag("Chest"))
        {
            isVictory = true;
            if (GameManager.instance != null)
            {
                GameManager.instance.TriggerVictoryUI();
            }
        }

        if (coll.gameObject.CompareTag("Heart")) {
            maxHealth++;
            AudioManager.instance.PlaySound(SOUND_COLLECT);
            UpdateUI(); 
            GameObject tempCollect_Effect = Instantiate(collect_EffectPrefab, coll.gameObject.transform.position, Quaternion.identity);
            Destroy(tempCollect_Effect, .401f);
            Destroy(coll.gameObject);
        }
        
        if (coll.gameObject.CompareTag("Arrow_Enemy")) {
            TakeDamage(1);
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.CompareTag("Diamond")) {
            currentDiamonds++;
            AudioManager.instance.PlaySound(SOUND_COLLECT);
            UpdateUI(); 
            GameObject tempCollect_Effect = Instantiate(collect_EffectPrefab, coll.gameObject.transform.position, Quaternion.identity);
            Destroy(tempCollect_Effect, .401f);
            Destroy(coll.gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheckPoint == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheckPoint.position, groundCheckRadius);
    }

    void Die() {
        Debug.Log(this.gameObject.name + " Died!");
        CameraShake.instance.Shake(4f, .18f);
        AudioManager.instance.PlaySound(SOUND_EXPLOSION);
        GameObject tempExplosion = Instantiate(explosionPrefab, explosionSpawnPoint.position, Quaternion.identity);
        Destroy(tempExplosion, .901f);
        GameManager.instance.TriggerGameOverUI();
        Destroy(this.gameObject);
    }
}