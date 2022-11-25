using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HassanAnimetion : MonoBehaviour
{
    Transform target = null;
    public Animator anim;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public void MovetoPoint(Vector3 point)
    {
        agent.SetDestination(point);
    }

    // Update is called once per frame
    void Update()
    {
        float speed =  agent.velocity.magnitude / agent.speed;//ความเร็วการเคลื่อนที่
        if (speed>0)
        {
            anim.SetBool("isWalk",true);
        }
        else
        {
            anim.SetBool("isWalk",false);
        }

        if (target!=null)
        {
            MovetoPoint(target.position);
        }
        if (Input.GetMouseButtonDown(1) && Hassanmovement.instance.showAxe)
        {
            anim.SetTrigger("Attack");
            Hassanmovement.instance.isAttack = true;
        }
        if (Input.GetMouseButtonUp(1) && Hassanmovement.instance.showAxe)
        {
            Hassanmovement.instance.isAttack = false;
        }
        
    } 
}
