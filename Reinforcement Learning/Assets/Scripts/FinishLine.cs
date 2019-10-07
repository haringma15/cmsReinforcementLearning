using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 200);
            PlayerPrefs.SetInt("gameover", 1);
            Destroy(this);
        }
    }
}
