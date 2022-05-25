using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    #region �ֹ��� ����
    public enum SelectedMain { HG, SMG, AR, SR }; //�� ���� ����
    public static SelectedMain selectedMain; //���� �ڽ��� ����ϴ� 

    public Transform muzzle; //�߻� ��ġ
    public Projectile projectile; //�Ѿ�

    public Snipe snipe; //�����ѿ� �Ѿ�

    public float msBetweenShots = 100; //���� ����
    public float muzzleVelocity = 35; //�Ѿ� �ӵ�
    public int maxBullet; //��ź��
    public float reloadTime; //������ �ð�

    float nextShotTime;

    bool canShoot; //�߻� ����?
    int leftBullet; //���� ��ź��
    public bool isreload; //������ ����

    #endregion
    #region �ֹ��� �޼ҵ�
    public void Shoot() //���
    {
        if (!isreload && Time.time > nextShotTime && leftBullet > 0)
        {
            leftBullet--; //źȯ �Ҹ�
            nextShotTime = Time.time + msBetweenShots / 1000; //���� źȯ ����


            if (selectedMain == SelectedMain.SR) //�����ѿ� źȯ
            {
                Snipe newSnipe = Instantiate(snipe, muzzle.position, muzzle.rotation); //�߻�ü ��ġ ����
                newSnipe.SetSpeed(muzzleVelocity);
            }
            else //�Ϲ� źȯ
            {
                Projectile newprojectile = Instantiate(projectile, muzzle.position, muzzle.rotation); //�߻�ü ��ġ ����
                newprojectile.SetSpeed(muzzleVelocity); //�߻�ü �ӵ� ����
            }
        }
    }

    public void Reload() //������
    {
        if (!isreload && leftBullet != maxBullet)
        {
            StartCoroutine(ReloadMove());
        }
    }
    IEnumerator ReloadMove() //������ ��Ŀ����;
    {
        isreload = true;
        yield return new WaitForSeconds(reloadTime);

        isreload = false;
        leftBullet = maxBullet;
    }
    #endregion


    #region �ι��� ����

    public enum SelectedSub { BL, SG, GL, RL }; //�������� ����

    public static SelectedSub selectedSub; //���� �ڽ��� ����ϴ� ��������

    private bool can_Sub = true; //�߻� ���� ����
    public float subDelay = 3.0f; //1�� �߻��ϰ� ������

    public int subStock; //���� �����
    public int maxStock = 3; //�ִ� �����
    public float chargeTime = 5.0f; //���� ���� �ð�

    #region ��ź��
    public Bayonet bayonet;
    #endregion

    #region ��ź��
    public Shotgun shotgun;
    #endregion

    #region ����ź
    public Granade granade;
    public float range = 10f;
    #endregion

    #region �̻���
    public Missile missile;
    public float disMiss = 30f; //�̻��� ��ȿ��Ÿ�
    #endregion


    #endregion
    #region �ι��� �޼ҵ�
   
    public void SubShoot() //�� ���� �߻�
    {
        if (subStock > 0 && can_Sub == true) //���� ������ �������� ��밡��
        {
            WeaponUI.instance.DELAY = subDelay;
            subStock--;

            //��� ����

            if (selectedSub == SelectedSub.BL) 
            {
                Bayonet newBayonet = Instantiate(bayonet, muzzle.position, muzzle.rotation);
                newBayonet.pushBack();
            }
            else if (selectedSub == SelectedSub.SG)
            {
                Shotgun newShotgun = Instantiate(shotgun, muzzle.position, muzzle.rotation);
                newShotgun.SgShot();
            }
            else if (selectedSub == SelectedSub.GL) //��ź ���ý�
            {
                Granade newGranade = Instantiate(granade, muzzle.position, muzzle.rotation);
                newGranade.GetComponent<Rigidbody>().AddForce(muzzle.forward * range, ForceMode.Impulse);
            }
            else if (selectedSub == SelectedSub.RL) //�̻��� ���ý�
            {
                Missile newMissile = Instantiate(missile, muzzle.position, muzzle.rotation);
                newMissile.SetSpeed(muzzleVelocity);
            }

            StartCoroutine(SubDelay());
        }
    }

    IEnumerator SubDelay()
    {
        can_Sub = false;

        yield return new WaitForSeconds(subDelay);

        can_Sub = true;
    }
    #endregion

    #region ���� ����
    public enum SelectSpt { NON, ATK, MAG, REL };
    public static SelectSpt selectSpt;
    #endregion

    public void Start()
    { 
        switch (selectedMain)
        {
            case SelectedMain.HG:
                maxBullet = 8;
                reloadTime = 1.2f;
                msBetweenShots = 150;
                projectile.damage = 3.0f;
                break;
            case SelectedMain.SMG:
                maxBullet = 25;
                reloadTime = 1.5f;
                msBetweenShots = 100;
                projectile.damage = 1.0f;
                break;
            case SelectedMain.AR:
                maxBullet = 40;
                reloadTime = 1.8f;
                msBetweenShots = 200;
                projectile.damage = 2.0f;
                break;
            case SelectedMain.SR:
                maxBullet = 6;
                reloadTime = 2f;
                msBetweenShots = 400;
                projectile.damage = 5.0f;

                break;
        }

        switch (selectSpt) //���������� ������ ��������
        {
            case SelectSpt.ATK:
                projectile.damage *= 1.2f;  //���ݷ� 10% ����
                break;
            case SelectSpt.MAG: //��ź�� 20%, �ι��� ���� + 2
                maxBullet = (int)(maxBullet * 1.2f);
                maxStock += 2;
                break;
            case SelectSpt.REL: //������ �ӵ�, �ι��� �������ӵ� 80%
                reloadTime *= 0.8f;
                chargeTime *= 0.8f;
                break;
        }

        leftBullet = maxBullet;//���۽� �ֹ��� �ִ� ����
        subStock = maxStock; //���۽� �������� �ִ� ����

        StartCoroutine(SubCharge());
        WeaponUI.instance.CHARGE = chargeTime;
    }

    private void LateUpdate()
    {
        if (!isreload && leftBullet == 0)
        {
            Reload();
        }

    }

    public void Update()
    {
        //�� ����
        WeaponUI.instance.REMAINMAIN = leftBullet;
        WeaponUI.instance.MAXMAIN = maxBullet;
        WeaponUI.instance.ISRELOAD = isreload;

        //���� ����
        WeaponUI.instance.REMAINSUB = subStock;
        WeaponUI.instance.SUBMAX = maxStock;
    }

    IEnumerator SubCharge()
    {
        if (subStock != maxStock)
        {
            yield return new WaitForSeconds(chargeTime); //���� ������ �ð���
            subStock++;

            if (subStock > maxStock)
            {
                subStock = maxStock;
            }

            StartCoroutine(nameof(SubCharge), chargeTime);
        }
        else
        {
            yield return new WaitForSeconds(0); //���� �Ҹ����� ����

            StartCoroutine(nameof(SubCharge)); //������ ���� ���ϸ� ������ ���� ��� ����
        }
    }
}

