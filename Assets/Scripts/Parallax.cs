using UnityEngine;

/// <summary>
/// Used to animate background images
/// </summary>
[RequireComponent(typeof(MeshRenderer))]
public class Parallax : MonoBehaviour
{
    [Header("Parameters")]
    public float animationSpeed = 1f;
    
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }

}
