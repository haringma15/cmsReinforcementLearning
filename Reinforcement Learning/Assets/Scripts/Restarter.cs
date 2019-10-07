using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    void Update() {
        if (PlayerPrefs.GetInt("gameover") == 1) {
            PlayerPrefs.SetInt("gameover", 0);
            SceneManager.LoadScene("BallGame");
        }
    }
}
