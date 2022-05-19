using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Projectile projectile; // 탄환 가져오기
    public int pellets; //산탄총에서 나갈 탄환 수
    public float spreadAngle; //탄환이 흩어지는 정도
    List<Quaternion> shell; //산탄총 탄환 개념(리스트 이용)

    private void Awake() //시작시 설정(산탄총 탄환 생성)
    {
    }
    // Start is called before the first frame update

    void sgShoot()
    {
        
    }

}
