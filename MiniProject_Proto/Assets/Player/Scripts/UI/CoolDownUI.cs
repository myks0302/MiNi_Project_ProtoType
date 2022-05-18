using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDownUI : MonoBehaviour
{
    //연동
    public static CoolDownUI instance; //중복 생성을 막기 위한 제한선
    private void Awake() // 시작 할때
    {
        CoolDownUI.instance = this;
    }

    #region 쿨타임 연동

    //쿨타임 
    float coolDownTime;

    public Text coolDownUi;

    public float COOLDOWN 
    {
        get { return coolDownTime; }
        set {
            coolDownTime = value;

            if (coolDownTime == 0)
            {
                coolDownUi.text = "OK";
            }
            else 
            {
                coolDownUi.text = "쿨타임 : " + coolDownTime;
                if (COOLDOWN < 0)
                {
                    COOLDOWN = 0; //마이너스 방지
                }
            }
        }
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        COOLDOWN -= Time.deltaTime; // 자동 감소
    }
}
