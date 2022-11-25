using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    public GameObject[] item;//ขาแกะ
   
   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Axe")
        {
            if(Hassanmovement.instance.isAttack==true)
            {
                GetComponent<Animator>().SetTrigger("die");
                Invoke("SpawnItem", 0.5f);
            }
        }
    }
    void SpawnItem()
    {
        foreach (var item in item)
        {
            item.SetActive(true);
        }
        Destroy(GetComponent<SphereCollider>());
        transform.Find("sheep_mesh").GetComponent<SkinnedMeshRenderer>().enabled = false;
    }
}
