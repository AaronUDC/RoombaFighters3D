using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaNPCController : MonoBehaviour
{
    #region Wandering targets
    [Header("Wandering targets")]
    public GameObject targetsGroup;
    public Transform[] targets;
    #endregion

    private Animator animator;

    private FieldOfView fow;

    public Transform currentEnemyTarget;

    void Start(){
        animator = gameObject.GetComponent<Animator>();
        fow = gameObject.GetComponent<FieldOfView>();
    }
    void Update(){
        foreach(Transform target in fow.visibleTargets){
            if("Player".Equals(target.gameObject.tag)){
                animator.SetTrigger("EnemyDetected");
                animator.SetBool("EnemyHasCloseWeapon", true);
                currentEnemyTarget = target;
                break;
            }
        }

        
    }

}
