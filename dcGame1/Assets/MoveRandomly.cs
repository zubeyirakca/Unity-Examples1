using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandomly : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timerForNewPath;
    bool inCoRoutine;
    float rotspeed = 300;
    float rot = 0;
    Vector3 target;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


     Vector3 getNewRandomPosition()
    {

        Vector3 pos = new Vector3(0, 0, 0);
        
        return pos;

    }

    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerForNewPath);
        GetNewPath();
        inCoRoutine = false;
    }

    void GetNewPath()
    {
        target = getNewRandomPosition();
        navMeshAgent.SetDestination(target);
    }
    void Update()
    {
        if (!inCoRoutine)
        {
            StartCoroutine(DoSomething());

        }
    }
}
