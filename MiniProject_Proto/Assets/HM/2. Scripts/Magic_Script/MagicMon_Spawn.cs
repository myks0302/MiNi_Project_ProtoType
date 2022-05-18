using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMon_Spawn : MonoBehaviour
{
   public GameObject magicMon;
    GameObject magicMon_Spwan;
    Transform where_MagicMon_Spawn;

    float a = 0;

    int b = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay_Time_And_Limit();
    }

    public void Spawn()
    {
        magicMon_Spwan = Instantiate(magicMon);

        magicMon_Spwan.transform.position = this.transform.position;

        b++;
    }
    void Delay_Time_And_Limit()
    {
        a += Time.deltaTime;
        
        if (a > 3 && b <= 5)
        {        
                Spawn();
                a = 0;          
        }
    }
}
