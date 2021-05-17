using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AtackCloseState : StateMachineBehaviour
{
    private NavMeshAgent agent;
    public GameObject gameObject;

    public Transform target;

    public float minAtackDistance = 0.7f;


    public float attackCooldown;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {  
        this.agent = animator.gameObject.GetComponent<NavMeshAgent>();
        this.gameObject = animator.gameObject;
        
        target = gameObject.GetComponent<RoombaNPCController>().enemyTarget;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        if (target != null){

            //Vamos a por el jugador hasta estar suficientemente cerca, entonces le atacamos
            if(Vector3.Distance(gameObject.transform.position, target.position) < minAtackDistance){
                gameObject.GetComponent<EquipmentController>().Atacar();
                animator.SetTrigger("IAtacked");
            }else{
                agent.SetDestination(target.position);
            }
        }
    }

    
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Para no atacar sin parar, tenemos un cooldown hasta que pueda volver a ir a por el jugador
        gameObject.GetComponent<RoombaNPCController>().StartWaitForAttackCooldown(attackCooldown);
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
