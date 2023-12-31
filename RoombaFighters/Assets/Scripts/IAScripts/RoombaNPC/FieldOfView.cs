using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    [Header("View cone")]
    public float viewRadius;
    [Range(0,360)]
    public float viewAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;

    public List<Transform> visibleTargets;

    public float delay = 0.5f;


    void Start(){
        StartCoroutine("FindTargetsWithDelay", delay);
    }
    IEnumerator FindTargetsWithDelay(float delay){
        while(true){
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }
    void FindVisibleTargets(){
        visibleTargets.Clear();
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);

        for(int i = 0; i< targetsInViewRadius.Length; i++){
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.position -transform.position).normalized;
            if(Vector3.Angle(transform.forward, dirToTarget)<viewAngle/2){
                float distToTarget = Vector3.Distance(target.position, transform.position);

                if(!Physics.Raycast(transform.position, dirToTarget, distToTarget, obstacleMask)){
                    if(target.gameObject != gameObject)
                        visibleTargets.Add(target);
                }  
            }
        }
    }

    public Vector3 DirFromAngle(float angleDegrees, bool isGlobalAngle){
        if(!isGlobalAngle){
            angleDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleDegrees * Mathf.Deg2Rad));
    }
}
