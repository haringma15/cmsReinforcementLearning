using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public Text highestText;

    void Update() {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("score");
        highestText.text = "Highest: " + PlayerPrefs.GetInt("highest");
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highest")) {
            PlayerPrefs.SetInt("highest", PlayerPrefs.GetInt("score"));
        }
    } 
}
