using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteminaUI : MonoBehaviour
{ 

    public static SteminaUI instance; //중복 생성을 막기 위한 제한선
    private void Awake() // 시작 할때
    {
        SteminaUI.instance = this;
    }

    float Stemina;
    public Text SteminaUi;

    float MaxStemina;

    public float STEMINA
    {
        get { return Stemina; }
        set
        {
            Stemina = value;
            
            SteminaUi.text = "현재 스테미나 :  " + Stemina;
        }
    }

    public float MAXSTEMINA
    {
        get { return MaxStemina; }
        set
        {
            MaxStemina = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SteminaUi.text = "현재 스테미나 :  " + MAXSTEMINA;
    }

    // Update is called once per frame
    void Update()
    {       
        STEMINA += Time.deltaTime;

        if (STEMINA > MAXSTEMINA) 
        {
            STEMINA = MAXSTEMINA;
        }
    }
}
