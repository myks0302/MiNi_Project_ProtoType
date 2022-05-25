using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
    protected float StartingHealth; //���� ü��(�ִ� ü��)

    protected float health; //���� ü��   

    public float HEALTH
    {
        get { return health; }

        set {
            health = value;
        }
    } //ü�� ����

    public float MAXHEALTH
    {
        get { return StartingHealth; }

        set
        {
            StartingHealth = value;
        }
    } //�ִ� ü�� ����

    protected bool dead; //��� ����

    // Start is called before the first frame update
    protected virtual void Start()
    {
        HEALTH = MAXHEALTH;
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
        GameObject.Destroy(gameObject, 3f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
