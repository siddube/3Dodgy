using UnityEngine;

public class Mover : MonoBehaviour
{
    /// <summary>
    /// This class is responsible for moving the player in the scene.
    /// </summary>


    // Header attribute for better organization in the Inspector
    // Setting for movement speed
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 10f;

    // Speed components along each axis
    private float xSpeed = 0.0f;
    private float ySpeed = 0.0f;
    private float zSpeed = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xSpeed, ySpeed, zSpeed);
    }
}
