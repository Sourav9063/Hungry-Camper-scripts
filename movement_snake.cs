using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement_snake : MonoBehaviour
{
    private NavMeshAgent nma = null;
    private GameObject[] random;
    private int CurrentRandom;

    private void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        random = GameObject.FindGameObjectsWithTag("random");
    }

    private void Update()
    {
        if(nma.hasPath==false)
        {
            CurrentRandom = Random.Range(0, random.Length + 1);
            nma.SetDestination(random[CurrentRandom].transform.position);
        }
    }
}
