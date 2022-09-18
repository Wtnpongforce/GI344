using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private PlayerController thePlayer;

    [SerializeField] private Animator myanim;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                myanim.SetBool("GateOpen2",true);
                Destroy(GameObject.FindWithTag("Key"));
            }
        }
    }
    /*private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                thePlayer.followingKey.followTarget = transform;
                myanim.SetBool("GateOpen2",false);
        }
    }*/
}
