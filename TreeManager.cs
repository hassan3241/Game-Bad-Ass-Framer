using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
   public GameObject items;//ฟืน
   private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Axe")
        {
            if(Hassanmovement.instance.isAttack==true)
            {
                Invoke("SpawnItem", 0.5f);
            }
        }
    }
    void SpawnItem()
    {
        items.SetActive(true);
        Destroy(GetComponent<CapsuleCollider>());
        GetComponent<MeshRenderer>().enabled = false;
    }
}

