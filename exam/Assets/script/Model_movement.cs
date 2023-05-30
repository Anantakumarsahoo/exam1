using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Model_movement : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform target;



    public Animator zombi_movement;

    public NavMeshAgent agent;
    void Start()
    {



       


        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);


        zombi_movement.SetTrigger("walk");



    }
}
