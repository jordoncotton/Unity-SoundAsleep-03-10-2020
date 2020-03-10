using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterBehaviour : MonoBehaviour
{

    public GameObject[] Waypoint;

    private int curntPoint = 0;

    private NavMeshAgent agent;

    public bool Pathfinding;

    public Vector3 Ref;

    public bool IdleState; //state of monster when idle
    public bool RoamingState; //state of monster when roamoming its normal path
    public bool AlertedState; //state of monster when alerted to noise
    public bool InvestingState; //state of monster when moving towards the noise
    public bool SearchState; //state of monster when searching for the source of the noise at the position that the noise was made
    public bool DiscoveryState; //state of monster when it discovers the source of the noise and belives the source of the noise is something that needs to be destroyed
    public bool ChaseState; //state of monster  when it runs towards the source of the noise
    public bool KillState; //state of monster  when it kills the player

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        Pathfinding = true;

        NextPoint();

        Ref = new Vector3(0.0f, 0.0f, 0.0f);


        IdleState = false;
        RoamingState = true;
        AlertedState = false;
        InvestingState = false;
        SearchState = false;
        DiscoveryState = false;
        ChaseState = false;
        KillState = false;

}

    void NextPoint()
    {
        if (Waypoint.Length == 0)
        {
            return;
        }

        agent.destination = Waypoint[curntPoint].transform.position;

        curntPoint = (curntPoint + 1) % Waypoint.Length;
    }
    // Update is called once per frame
    void Update()
    {
        if(Pathfinding == false)
        {
            agent.destination = Ref;

            if(!agent.pathPending && agent.remainingDistance <2)
            {
                Pathfinding = true;
            }
        }
        if (Pathfinding == true)
        {
            if (!agent.pathPending && agent.remainingDistance < 2)
            {
                NextPoint();
            }
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("SOUND"))
        {

            Pathfinding = false;

            Ref = collider.gameObject.transform.position;
        }

        Debug.Log("N");
    }

   
}
