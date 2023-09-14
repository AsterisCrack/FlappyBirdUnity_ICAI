using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Dependencies")]
    public GameObject pipesPrefab;
    
    [Header("Parameters")]
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 2f;
    
    public void Spawn()
    {
        // How we create new objects in Unity
        GameObject newPipe = Instantiate(pipesPrefab, Vector3.zero, Quaternion.identity);
        
        // newPipe.transform.position += ...
    }
}
