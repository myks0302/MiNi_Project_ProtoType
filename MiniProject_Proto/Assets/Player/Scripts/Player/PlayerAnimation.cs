using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    //플레이어 가져오기
    Player player; //이동

  
    // Start is called before the first frame update
    void Start()
    {
        //플레이어 컴포넌트 가져오기
        player = gameObject.GetComponentInParent<Player>();
    }


    public void OnIdle() 
    {
        player.OnIdle();
    }
    public void OnMoveForward() //플레이어
    {
        player.OnMoveForward();
    }
    public void OnRun() 
    {
        player.OnRun();
    }
    public void OnReload() //무기
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
