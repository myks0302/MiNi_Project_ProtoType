using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ȭ�� �̵��� ���� ���̺귯�� ��ȯ

public class TitleUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnApplicationQuit()
    {
        Application.Quit();
       //���� ����
    }
    public void gotoSelctGear() 
    {
        SceneManager.LoadSceneAsync(1);
        //��� ���� ���(SelectUI ������ �̵�)
    }
}
