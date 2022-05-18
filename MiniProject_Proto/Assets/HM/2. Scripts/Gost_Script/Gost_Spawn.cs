using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gost_Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject gost_1, gost_2, gost_3, gost_4, gost_5, gost_6;
    GameObject spwan_Gost;
    public Transform spawn_1, spawn_2, spawn_3, spawn_4, spawn_5, spawn_6;
    int random_pos;
    float a = 0;
                                 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay_Time();
    }

    public void Spawn()
    {
        random_pos = Random.Range(1, 4);

        switch(random_pos)
        {
            case 1:
                spwan_Gost = Instantiate(gost_1, spawn_1);
                spwan_Gost.transform.position = spawn_1.position;
                break;
            case 2:
                spwan_Gost = Instantiate(gost_2, spawn_2);
                spwan_Gost.transform.position = spawn_2.position;
                break;
            case 3:
                spwan_Gost = Instantiate(gost_3, spawn_3);
                spwan_Gost.transform.position = spawn_3.position;
                break;
            case 4:
                spwan_Gost = Instantiate(gost_4, spawn_4);
                spwan_Gost.transform.position = spawn_4.position;
                break;
            case 5:
                spwan_Gost = Instantiate(gost_5, spawn_5);
                spwan_Gost.transform.position = spawn_5.position;
                break;
            case 6:
                spwan_Gost = Instantiate(gost_6, spawn_6);
                spwan_Gost.transform.position = spawn_6.position;
                break;
        }
    }

    void Delay_Time()
    {
        a += Time.deltaTime;

        if (a > 3)
        {
            Spawn();
            a = 0;
        }
    }
}
