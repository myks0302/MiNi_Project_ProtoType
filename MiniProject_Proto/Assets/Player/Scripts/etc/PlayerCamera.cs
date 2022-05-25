using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera maincamera; //ī�޶� ����

    public Player player; //�Ѿư� �÷��̾�
    // Start is called before the first frame update
    void Start()
    {
        maincamera.GetComponent<Camera>(); //ī�޶� ������Ʈ ��������
        player.GetComponent<Player>(); //�÷��̾� ������Ʈ ��������
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) 
        {
            maincamera.transform.position = player.transform.position + new Vector3(0, 19, -15);
        }
    }
}
