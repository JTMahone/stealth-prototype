using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody body;
    private int playerSpeed = 5;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        body.velocity = new Vector3( Input.GetAxis("Horizontal") * playerSpeed, body.velocity.y, body.velocity.z);
        body.velocity = new Vector3( body.velocity.x, Input.GetAxis("Vertical") * playerSpeed, body.velocity.z);
    }
}
