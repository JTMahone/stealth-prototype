using UnityEngine;

public class EnemySightline : MonoBehaviour
{
    private BoxCollider boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
     
    }

    private void OnTriggerEnter(Collider collision)
    {

    }
}
