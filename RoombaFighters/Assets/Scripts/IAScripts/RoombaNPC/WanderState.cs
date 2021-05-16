using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class WanderState : StateMachineBehaviour
{
    public float wanderRadius;
    public float wanderTimer;
    private float timer;
    public GameObject targetsGroup;
    public Transform[] targets;
    private NavMeshAgent agent;
    public GameObject gameObject;

    private Vector3 newDestination;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        this.agent = animator.gameObject.GetComponent<NavMeshAgent>();
        this.gameObject = animator.gameObject;
        
        targets = gameObject.GetComponent<RoombaNPCController>().targets;
        GoNewPlace();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
        timer += Time.deltaTime;
        if (timer >= wanderTimer){
            GoNewPlace();
            timer = 0;
        }
        
        //Si llega a su objetivo, vamos a otro sitio
        if(Vector3.Distance(gameObject.transform.position, newDestination) < 0.2f){
                GoNewPlace();
                timer = 0;
            }

    }

    void GoNewPlace(){
        int i = Random.Range(0,targets.Length - 1);
        newDestination = RandomNavSphere(targets[i].position, wanderRadius, -1);
        agent.SetDestination(newDestination);
    }
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask){
        Vector3 randDirection = Random.insideUnitSphere * dist;
 
        randDirection += origin;
 
        NavMeshHit navHit;
 
        NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
        return navHit.position;
    }
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
  
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
