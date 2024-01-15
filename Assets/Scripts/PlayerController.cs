using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -8f;
    public float maxX = 8f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float newPositionX = transform.position.x + horizontalInput * speed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, minX, maxX);

        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Debug.Log("Game Over");
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
