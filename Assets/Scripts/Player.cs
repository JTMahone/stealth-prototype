using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody body;
    private int moveSpeed = 20;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        body.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, body.velocity.y, body.velocity.z);
        body.velocity = new Vector3(body.velocity.x, body.velocity.z, Input.GetAxis("Vertical") * moveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
