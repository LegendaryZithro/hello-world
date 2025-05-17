using UnityEngine;
using UnityEngine.AI;

// Simple enemy that chases the player when within range
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float chaseDistance = 5f;

    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target == null) return;

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= chaseDistance)
        {
            agent.SetDestination(target.position);
        }
    }
}
