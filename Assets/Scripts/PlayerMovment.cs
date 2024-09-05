using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody body;
    private int moveSpeed = 5;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        body.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, body.velocity.y, body.velocity.z);
        body.velocity = new Vector3(body.velocity.x, Input.GetAxis("Vertical") * moveSpeed, body.velocity.z);
    }
}
