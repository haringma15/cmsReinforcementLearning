using UnityEngine;

public class RouteController : MonoBehaviour
{
    private Route[] routes;

    void Start() {
        routes = GetComponentsInChildren<Route>();
        foreach (Route route in routes) route.gameObject.SetActive(false);

        int newRouteIndex = Random.Range(0,9);
        foreach (Route route in routes) if (route.id == newRouteIndex) route.gameObject.SetActive(true);
    }
}
