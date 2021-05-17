using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GetPowerUpState : StateMachineBehaviour
{    
    public float pickUpTimer;
    private float timer;

    private NavMeshAgent agent;
    public GameObject gameObject;

    public Transform target;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        this.agent = animator.gameObject.GetComponent<NavMeshAgent>();
        this.gameObject = animator.gameObject;
        
        target = gameObject.GetComponent<RoombaNPCController>().currentRecolectableTarget;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

        timer += Time.deltaTime;
        if (timer >= pickUpTimer){
            animator.SetTrigger("ItemObtained");
            timer = 0;
        }

        if (target != null){
            agent.SetDestination(target.position);

            if(Vector3.Distance(gameObject.transform.position, target.position) < 0.4f){
                animator.SetTrigger("ItemObtained");
            }

        }else{
            animator.SetTrigger("ItemObtained");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
   // {   
  
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
