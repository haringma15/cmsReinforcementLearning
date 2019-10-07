using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int force = 2;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) rb.AddForce(0, 0, force, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.DownArrow)) rb.AddForce(0, 0, -force, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.LeftArrow)) rb.AddForce(-force, 0, 0, ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.RightArrow)) rb.AddForce(force, 0, 0, ForceMode.Acceleration);
    }
}
