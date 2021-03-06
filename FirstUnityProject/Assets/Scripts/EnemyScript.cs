﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;
    [SerializeField]
    ParticleSystem particle;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            ParticleSystem cParticle = Instantiate(particle, transform.position, Quaternion.identity);

            Health healthScript = GetComponent<Health>();
            healthScript.AddHealth(-1f);
            Destroy(other.gameObject);
        }
    }
}
