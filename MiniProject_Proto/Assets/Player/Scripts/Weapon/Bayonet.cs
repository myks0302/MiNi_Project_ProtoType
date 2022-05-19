using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bayonet : MonoBehaviour
{
    public float pushForce = 10f; //�о�� ����
    public float radius = 2.0f; //�ݰ�

    public float damage = 2f; //�ִ� ���ط�

    void pushBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius); //�ݰ� �� �� üũ

        foreach (Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>(); //���� �ٵ� üũ
            LivingEntity livingEntity = near.GetComponent<LivingEntity>(); //����ü üũ

            if (rig != null)
            {
                rig.AddExplosionForce(pushForce, transform.position, radius, 1f, ForceMode.Impulse); //�ݰ泻 ��ƼƼ �з���.
            }

            if (livingEntity != null)
            {
                livingEntity.TakeHit2(damage); //�ݰ泻 ��ƼƼ���� ������      
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
