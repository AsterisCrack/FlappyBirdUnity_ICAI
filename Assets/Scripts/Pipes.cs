using UnityEngine;

public class Pipes : MonoBehaviour
{
    [Header("Dependencies")]
    public Transform top;
    public Transform bottom;

    [Header("Parameters")]

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        // transform.position += ...
    }

}
