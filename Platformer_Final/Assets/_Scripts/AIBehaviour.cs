using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviour : MonoBehaviour
{
    public Transform[] waypoints;
    public GameObject player;
    public EnemySprite enemySpriteAnim;
    
    private bool canPatrol, canHunt;
    private NavMeshAgent agent;
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs;
    private int i = 0;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private IEnumerator Patrol()
    {
        canPatrol = true;
        canHunt = false;
        while (canPatrol)
        {
            yield return wffu;
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                yield return wfs;
                agent.destination = waypoints[i].position;
                i = (i + 1) % waypoints.Length;
                enemySpriteAnim.FlipSprite();
            }
        }
    }
    
    private IEnumerator Hunt(Transform obj)
    {
        canHunt = true;
        canPatrol = false;
        while (canHunt)
        {
            yield return wffu;
            agent.destination = obj.position;
        }
    }

    public void StartPatrol()
    {
        StartCoroutine(Patrol());
    }

    public void StartHunt()
    {
        StartCoroutine(Hunt(player.transform));
    }

    
}
