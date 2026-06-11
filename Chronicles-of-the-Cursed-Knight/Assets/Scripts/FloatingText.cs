using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public TextMesh textMesh;

    void Start()
    {
        // Solo destruimos el objeto después de 1 segundo.
        Destroy(this.gameObject, 1.01f);
    }

    // Creamos una función pública para recibir el daño real
    public void SetDamageText(int damageAmount)
    {
        textMesh.text = damageAmount.ToString();
    }
}