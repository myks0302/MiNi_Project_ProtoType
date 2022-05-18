using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gost_Move : MonoBehaviour
{
    public NavMeshAgent gost_agent;

    [SerializeField]
    GameObject trToPlayer;
    
    float dir_player;

    public bool is_Move = true;
    public float dir_Attack;

    // Start is called before the first frame update
    void Start()
    {
        trToPlayer = GameObject.FindGameObjectWithTag("Player");

        gost_agent = GetComponent<NavMeshAgent>();
        gost_agent.SetDestination(trToPlayer.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        dir_player = Vector3.Distance(trToPlayer.transform.position, transform.position);

        if(dir_player < dir_Attack)
        {
            gost_agent.isStopped = true;
            gost_agent.velocity = Vector3.zero;
            is_Move = false;
        }
        else
        {
            gost_agent.isStopped = false;
            is_Move = true;
            gost_agent.SetDestination(trToPlayer.transform.position);
        }

    }
}
