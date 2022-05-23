using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bayonet : MonoBehaviour
{
    public float pushForce = 10f; //�о�� ����
    public float radius = 2.0f; //�ݰ�

    public float damage = 2f; //�ִ� ���ط�

    public GameObject slash; //����Ʈ
   
    public void pushBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius); //�ݰ� �� �� üũ

        foreach (Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>(); //���� �ٵ� üũ
            LivingEntity livingEntity = near.GetComponent<LivingEntity>(); //����ü üũ

            if (rig != null && !livingEntity.name.Contains("Player"))
            {
                rig.AddExplosionForce(pushForce, transform.position, radius, 1f, ForceMode.Impulse); //�ݰ泻 ��ƼƼ �з���.
            }

            if (livingEntity != null && !livingEntity.name.Contains("Player"))
            {
                livingEntity.TakeHit2(damage); //�ݰ泻 ��ƼƼ���� ������      
            }

        }
        Instantiate(slash, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

