using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    private Rigidbody body;
    private int moveSpeed = 3;
    private bool flipped = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (flipped == false)
        {
            body.velocity = new Vector3(moveSpeed, body.velocity.y, body.velocity.z);
        }
        else if (flipped == true)
        {
            body.velocity = new Vector3(moveSpeed * -1, body.velocity.y, body.velocity.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Map")
        {
            flipped = !flipped;
        }
    }
}
