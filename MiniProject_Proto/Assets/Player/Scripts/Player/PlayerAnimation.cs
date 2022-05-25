using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    //�÷��̾� ��������
    Player player; //�̵�

  
    // Start is called before the first frame update
    void Start()
    {
        //�÷��̾� ������Ʈ ��������
        player = gameObject.GetComponentInParent<Player>();
    }


    public void OnIdle() 
    {
        player.OnIdle();
    }
    public void OnMoveForward() //�÷��̾�
    {
        player.OnMoveForward();
    }
    public void OnRun() 
    {
        player.OnRun();
    }
    public void OnReload() //����
    {
        player.OnReload();
    }

    public void OnMoveBack() 
    {
    }


    public void OnDeath() 
    {
        player.onDead();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
