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

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        this.agent = animator.gameObject.GetComponent<NavMeshAgent>();
        this.gameObject = animator.gameObject;
        
        targets = gameObject.GetComponent<RoombaNPCController>().targets;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        
        timer += Time.deltaTime;
        if (timer >= wanderTimer){
            int i = Random.Range(0,targets.Length - 1);
            Vector3 newPos = RandomNavSphere(targets[i].position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
        

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
