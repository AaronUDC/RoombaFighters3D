using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using UnityEditor;

public class RunAwayState : StateMachineBehaviour
{   
    public float refreshDestinationRate;
    public float timer;
    public Transform runAwayTarget;
    private NavMeshAgent agent;
    public GameObject gameObject;

    public float targetDistance;

    public Vector3 dirToTarget;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        this.agent = animator.gameObject.GetComponent<NavMeshAgent>();
        this.gameObject = animator.gameObject;
        
        runAwayTarget = gameObject.GetComponent<RoombaNPCController>().currentEnemyTarget;

        RunAway();

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        if (timer >= refreshDestinationRate){
            RunAway();
            timer = 0;
        }
        
        animator.SetFloat("TargetDistance", Vector3.Distance(gameObject.transform.position, runAwayTarget.position));

    }

    private bool RunAway(){
        dirToTarget = (gameObject.transform.position - runAwayTarget.position).normalized;
        NavMeshHit navHit;
        
        NavMesh.SamplePosition (gameObject.transform.position + (dirToTarget * targetDistance), out navHit, 5 , -1);
            
        return agent.SetDestination(navHit.position);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
