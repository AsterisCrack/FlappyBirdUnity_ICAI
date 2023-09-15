using UnityEngine;

public class Pipes : MonoBehaviour
{
    [Header("Dependencies")]
    public Transform top;
    public Transform bottom;

    [Header("Parameters")]

    private float leftEdge;
    public float speed = 1f;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //Check if the pipe is offscreen
        if (transform.position.x < leftEdge)
        {
            Despawn();
        }
    }

    private void Despawn()
    {

        Destroy(gameObject);
    }


}
