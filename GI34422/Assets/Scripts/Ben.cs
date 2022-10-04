using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Ben : MonoBehaviour
{
    private bool _isFollowing;
    public float followSpeed;

    public Transform followTarget;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
            
            if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(-90,0,270);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(-90,0,360);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(-90,0,180);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(-90,0,90);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!_isFollowing)
            {
                PlayerController thePlayer = FindObjectOfType<PlayerController>();
                
                followTarget = thePlayer.benFollowPoint;
                //transform.rotation = Quaternion.Euler(-90,0,0);
                _isFollowing = true;
                thePlayer.followingBen = this;
            }
        }
    }
}
