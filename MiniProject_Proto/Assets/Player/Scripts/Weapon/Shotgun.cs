using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Projectile projectile; // źȯ ��������
    public int pellets; //��ź�ѿ��� ���� źȯ ��
    public float spreadAngle; //źȯ�� ������� ����
    List<Quaternion> shell; //��ź�� źȯ ����(����Ʈ �̿�)

    private void Awake() //���۽� ����(��ź�� źȯ ����)
    {
    }
    // Start is called before the first frame update

    void sgShoot()
    {
        
    }

}
