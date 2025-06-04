using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        rigidBody.linearVelocity = new Vector3(x, 0, z);
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();
    }
}

