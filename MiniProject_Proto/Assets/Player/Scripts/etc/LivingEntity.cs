using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
    public float StartingHealth; //���� ü��

    protected float health; //���� ü��

    public float HEALTH
    {
        get { return health; }

        set {
            health = value;
        }
    } //ü�� ����
   
    
    protected bool dead; //��� ����

    // Start is called before the first frame update
    protected virtual void Start()
    {
        HEALTH = StartingHealth;
    }

    public void TakeHit(float damage, RaycastHit hit) 
    {
        HEALTH -= damage;

        if (health <= 0 && !dead) 
        {
            Dead();
        }
    }

    public void TakeHit2(float damage) //����ź�� ���� ������ ���� (�ܼ� ������ �޴� ����)
    {
        HEALTH -= damage;

        if (health <= 0 && !dead)
        {
            Dead();
        }
    }

    protected void Dead() 
    {
        dead = true;
        GameObject.Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
