using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyView : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public Transform teleportTarget;

    public bool isAngered;

    public NavMeshAgent agent;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance <= 5)
        {
            isAngered = true;
        }

        if (distance > 5f)
        {
            isAngered = false;
        }

        if (isAngered)
        {
            agent.isStopped = false;

            agent.SetDestination(player.transform.position);
        }

        if (!isAngered)
        {
            agent.isStopped = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = teleportTarget.transform.position;
        }
    }
}
