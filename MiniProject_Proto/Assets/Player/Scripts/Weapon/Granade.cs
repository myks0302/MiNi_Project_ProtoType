using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public GameObject explosionEffect; //���� ȿ�� 
    public float delay = 3.0f; //���� �ǰ� ���� �Ҷ������� �����ð�

    public float explodeForce = 10f; //���� ����
    public float radius = 2.0f; //���߹ݰ�
    
    public float damage = 2f; //�ִ� ���ط�
    void explode() 
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius); //���� �������κ��� �ݰ泻 �־��� ���ӿ�����Ʈ üũ

        foreach (Collider near in colliders) 
        {
            Rigidbody rig = near.GetComponent<Rigidbody>();
            LivingEntity livingEntity = near.GetComponent<LivingEntity>();

            if (rig != null) 
            {
                rig.AddExplosionForce(explodeForce, transform.position, radius, 1f, ForceMode.Impulse); //�ݰ泻 ��ƼƼ �з���.
            }

            if (livingEntity != null)
            {
                livingEntity.TakeHit2(damage); //�ݰ泻 ��ƼƼ���� ������      
            }

        }
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void Start()
    {
        this.GetComponent<Rigidbody>().AddTorque(Vector3.forward, ForceMode.Impulse);
        Invoke("explode", delay);
    }

    private void Update()
    {
        
    }


}
