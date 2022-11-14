using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Transform target;
    private Vector3 dir;
    public float speed = 10f, bulletTime = 5f;
    public IntData playerHealth;

    private void Start()
    {
        Destroy(gameObject, bulletTime);
    }

    public void Seek(Transform _target)
    {
        target = _target;
        dir = target.position - transform.position;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        
        float distanceThisFrame = speed * Time.deltaTime;
        
        
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.IncrementValue(-1);
            Destroy(gameObject);
        }
    }
}
