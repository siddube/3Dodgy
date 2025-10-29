using UnityEngine;

/// <summary>
/// This class is responsible for dropping objects in the scene.
/// </summary>
public class Dropper : MonoBehaviour
{
    // Header attribute for better organization in the Inspector
    // Setting for time to drop the object
    [Header("Dropper Settings")]
    [SerializeField] private int timeToDrop = 3;

    /// References to the MeshRenderer and Rigidbody components
    private MeshRenderer meshRenderer;
    private new Rigidbody rigidbody;

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        // Disable the mesh renderer and gravity at the start
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (Time.time >= timeToDrop)
        {
            // Enable the mesh renderer and gravity when the time to drop is reached
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
