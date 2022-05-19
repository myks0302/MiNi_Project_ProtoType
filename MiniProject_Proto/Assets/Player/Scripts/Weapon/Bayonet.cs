using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bayonet : MonoBehaviour
{
    public float pushForce = 10f; //밀어내는 위력
    public float radius = 2.0f; //반경

    public float damage = 2f; //주는 피해량

    void pushBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius); //반경 내 적 체크

        foreach (Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>(); //물리 바디 체크
            LivingEntity livingEntity = near.GetComponent<LivingEntity>(); //생명체 체크

            if (rig != null)
            {
                rig.AddExplosionForce(pushForce, transform.position, radius, 1f, ForceMode.Impulse); //반경내 엔티티 밀려남.
            }

            if (livingEntity != null)
            {
                livingEntity.TakeHit2(damage); //반경내 엔티티에게 데미지      
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
