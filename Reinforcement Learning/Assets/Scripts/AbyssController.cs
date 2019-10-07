using UnityEngine;

public class AbyssController : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            PlayerPrefs.SetInt("score", 0);
            PlayerPrefs.SetInt("gameover", 1);
            Destroy(this);
        }
    }
}
