using UnityEngine;

public class Chest : MonoBehaviour {

    public static Chest instance;

    private void Awake() {
        
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.CompareTag("Player")) {
            TriggerVictoryUI();
        }
    }

    public void TriggerVictoryUI() {
        GameManager.instance.TriggerVictoryUI();
    }
}
