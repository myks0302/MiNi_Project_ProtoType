using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gost_Controller : MonoBehaviour
{
    // '고스트' 체력
    int gost_HP = 100;

    // '고스트' 공격력
    int gost_Attack = 10;

    // '고스트'가 죽었는지 체크
    bool IsDead = false;

    // '고스트'가 이동하는지 체크
    bool IsMove = false;

    // '고스트'와 플레이어의 거리가 가까운지 체크
    bool IsClose = false;

    Animator gost_anim;
    Gost_Move gost_Move;

    // Start is called before the first frame update
    void Start()
    {
        gost_anim = GetComponent<Animator>();
        gost_Move = GetComponent<Gost_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gost_Move.is_Move == false)
        {
            Debug.Log("attack!");
            gost_anim.SetBool("isClose", true);
            gost_anim.SetBool("isMove", false);
        }
        else 
        {
            Debug.Log("move!");
            gost_anim.SetBool("isClose", false);
            gost_anim.SetBool("isMove", true);
        }
    }
}
