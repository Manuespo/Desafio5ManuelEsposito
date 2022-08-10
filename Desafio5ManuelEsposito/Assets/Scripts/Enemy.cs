using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    enum ZombieTypes { Stalker, Rotator }
    [SerializeField] ZombieTypes zombieType;
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 2f;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (zombieType)
        {
            case ZombieTypes.Stalker:
                {
                    chasePlayer();
                }
                break;
            case ZombieTypes.Rotator:
                {
                    lookPlayer();
                }
                break;
        }
    }

    private void lookPlayer()
    {
        transform.LookAt(playerTransform);
    }

    private void chasePlayer()
    {
        lookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2f)
            transform.position +=direction.normalized * speed * Time.deltaTime;
    }
}
