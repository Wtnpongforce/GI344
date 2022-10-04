using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Obstacle : MonoBehaviour
{
   private NavMeshAgent _agent;
   public Transform teleportTarget;
   public GameObject thePlayer;
   public Transform[] waypoints;
   int _waypointIndex;
   Vector3 _target;

   void Start()
   {
      _agent = GetComponent<NavMeshAgent>();
      UpdateDestination();
   }

   void Update()
   {
      if (Vector3.Distance(transform.position, _target) < 1)
      {
         IterateWaypoint();
         UpdateDestination();
      }
   }

   void UpdateDestination()
   {
      _target = waypoints[_waypointIndex].position;
      _agent.SetDestination(_target);
   }

   void IterateWaypoint()
   {
      _waypointIndex++;
      if (_waypointIndex == waypoints.Length)
      {
         _waypointIndex = 0;
      }
   }

   //เปลี่ยน position player แทนการทำลาย
   public void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         thePlayer.transform.position = teleportTarget.transform.position;
         this.Wait(2f, () =>
         {
            //thePlayer.transform.position = teleportTarget.transform.position;
         });
      }
   }
}
