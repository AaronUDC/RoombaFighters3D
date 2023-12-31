using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoombaNPCController : MonoBehaviour
{
    #region Wandering targets
    [Header("Wandering targets")]
    public GameObject targetsGroup;
    public Transform[] targets;
    #endregion

    private Animator animator;

    private FieldOfView fow;

    public Transform currentRecolectableTarget;

    public Transform enemyTarget;

    public NavMeshAgent agent;
    public float speed;

    public float responseTime;

    void Start(){
        animator = gameObject.GetComponent<Animator>();
        fow = gameObject.GetComponent<FieldOfView>();
        StartCoroutine("CheckTargets");
    }
    void Update(){
        //Boost de velocidad al tener el power up
        GameObject powerUp;
        if((powerUp = GetComponent<EquipmentController>().powerUp)!=null){
            Velocidad velocidadPowerUp;
            powerUp.TryGetComponent<Velocidad>(out velocidadPowerUp);

            if (velocidadPowerUp != null)
                agent.speed = velocidadPowerUp.aumento * speed;
            }else{
                agent.speed = speed;
            }

        
        //Comprobamos si tenemos un arma equipada
        if(GetComponent<EquipmentController>().arma == null)
            animator.SetBool("IHaveWeapon", false);
        else
            animator.SetBool("IHaveWeapon", true);
        
        
        //Analizamos lo que podemos ver
        /*foreach(Transform target in fow.visibleTargets){
            if(target != null){
                if("Player".Equals(target.gameObject.tag)){
                    animator.SetTrigger("EnemyDetected");
                    if(target.GetComponent<EquipmentController>().arma != null)
                        animator.SetBool("EnemyHasWeapon", true);
                    else animator.SetBool("EnemyHasWeapon", false);
                    currentRecolectableTarget = target;
                    break;
                } else if ("Trash".Equals(target.gameObject.tag)){
                    animator.SetTrigger("TrashDetected");
                    currentRecolectableTarget = target;
                    break;
                } else if ("ItemBox".Equals(target.gameObject.tag)){
                    animator.SetTrigger("ItemBoxDetected");
                    currentRecolectableTarget = target;
                    break;
                }
            }
        }      */  
    }

    private IEnumerator CheckTargets(){
        //Cada responseTime segundos analizamos lo que estamos viendo.
        yield return new WaitForSeconds(responseTime);
        //Analizamos lo que podemos ver
        foreach(Transform target in fow.visibleTargets){
            if(target != null){
                if("Player".Equals(target.gameObject.tag) && target.gameObject != gameObject){
                    animator.SetTrigger("EnemyDetected");
                    if(target.GetComponent<EquipmentController>().arma != null)
                        animator.SetBool("EnemyHasWeapon", true);
                    else animator.SetBool("EnemyHasWeapon", false);
                    enemyTarget = target;
                    break;
                } else if ("Trash".Equals(target.gameObject.tag)){
                    animator.SetTrigger("TrashDetected");
                    currentRecolectableTarget = target;
                    break;
                } else if ("ItemBox".Equals(target.gameObject.tag)){
                    animator.SetTrigger("ItemBoxDetected");
                    currentRecolectableTarget = target;
                    break;
                }
            }
        }
        //Volvemos a iniciar la corrutina
        StartCoroutine("CheckTargets");
    }
    //Hay que hacer este workarround porque para iniciar una corrutina la clase debe ser hija de MonoBehaviour
    public void StartWaitForAttackCooldown(float cooldown){
        StartCoroutine("WaitForNextAttack", cooldown);
    }
    public IEnumerator WaitForNextAttack(float cooldown){
        animator.SetBool("IsOffensive",false);
        yield return new WaitForSeconds(cooldown); 
        animator.SetBool("IsOffensive",true);
    } 

}
