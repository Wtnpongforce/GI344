using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Transform reSpawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = reSpawnPoint.transform.position;
    }
}
