using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public GameObject cameraTarget;
    private Vector3 distanceFromTarget = new Vector3(0, 3, -4);

    void Update() => transform.position = distanceFromTarget + cameraTarget.transform.position;
}
