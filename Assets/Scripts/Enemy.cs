using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    private int moveSpeed = 3;
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    private void Update()
    {
       if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
