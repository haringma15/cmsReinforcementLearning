using UnityEngine;

public class ColorChangeOnTouch : MonoBehaviour
{
    public Material newColor;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            GetComponent<Renderer>().material = newColor;
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 10);
            Destroy(this);
        }
    }
}
