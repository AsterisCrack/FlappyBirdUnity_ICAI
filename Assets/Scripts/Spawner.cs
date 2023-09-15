using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Dependencies")]
    public GameObject pipesPrefab;
    
    [Header("Parameters")]
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 2f;

    private float rightEdge;

    public void Spawn()
    {
        Debug.Log("Spawning pipes");
        // How we create new objects in Unity
        GameObject newPipe = Instantiate(pipesPrefab, Vector3.zero, Quaternion.identity);
        //Place it at the right edge of the screen
        newPipe.transform.position += Vector3.right * rightEdge;

        //Randomize the height
        float thisHeight = Random.Range(minHeight, maxHeight);
        newPipe.transform.position += thisHeight * Vector3.up;

    }

    public void StartSpawning()
    {
        InvokeRepeating(nameof(Spawn), 0f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke(nameof(Spawn));
    }

    public void Start()
    {   
        rightEdge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
    }
}
