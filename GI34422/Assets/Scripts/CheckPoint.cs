using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private List<GameObject> checkPoint;
    [SerializeField] private Vector3 vectorPoint;
    [SerializeField] private float dead;

    void Update()
    {
        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        vectorPoint = player.transform.position;
        Destroy(other.gameObject);
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("checkPoint"))
        {
            vectorPoint = player.transform.position;
            Destroy(GameObject.FindWithTag("checkPoint"));
        }
    }
}
