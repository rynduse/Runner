using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CpuPath : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject finish;
    void Update()
    {
        agent.SetDestination(finish.transform.position);
    }
}
