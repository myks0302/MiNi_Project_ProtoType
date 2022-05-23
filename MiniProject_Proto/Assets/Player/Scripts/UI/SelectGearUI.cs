using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectGearUI : MonoBehaviour
{
    public static SelectGearUI instance; //�ܵ� �ν��Ͻ�ȭ

    public void Awake()
    {
        SelectGearUI.instance = this;
    } //�ܵ�

    public GameObject gun;
    public GameObject player;
    //�ܺ� �Է��� �����ϵ��� Ŭ���� ����

    #region �ֹ��� ����
    public void selectMainHG() 
    {
        gun.GetComponent<Gun>().selectedMain = Gun.SelectedMain.HG;
    }

    public void selectMainSMG()
    {
        gun.GetComponent<Gun>().selectedMain = Gun.SelectedMain.SMG;
    }

    public void selectMainAR()
    {
        gun.GetComponent<Gun>().selectedMain = Gun.SelectedMain.AR;
    }

    public void selectMainSR()
    {
        gun.GetComponent<Gun>().selectedMain = Gun.SelectedMain.SR;
    }

    #endregion

    #region �ι��� ����
    public void selectSubBL()
    {
        gun.GetComponent<Gun>().selectedSub = Gun.SelectedSub.BL;
    }

    public void selectSubSG()
    {
        gun.GetComponent<Gun>().selectedSub = Gun.SelectedSub.SG;
    }

    public void selectSubGL()
    {
        gun.GetComponent<Gun>().selectedSub = Gun.SelectedSub.GL;
    }

    public void selectSubRL()
    {
        gun.GetComponent<Gun>().selectedSub = Gun.SelectedSub.RL;
    }

    #endregion

    #region ȸ������ ����

    public void selectDodgeSPR()
    {
        player.GetComponent<Player>().selectDodge = Player.SelectDodge.SPR;
    }

    public void selectDodgeSLD()
    {
        player.GetComponent<Player>().selectDodge = Player.SelectDodge.SLD;
    }

    public void selectDodgeBLK()
    {
        player.GetComponent<Player>().selectDodge = Player.SelectDodge.BLK;
    }

    #endregion

    #region ������� ����
    public void selectSptAtk() //���� �ν�Ʈ
    {
        gun.GetComponent<Gun>().selectSpt = Gun.SelectSpt.ATK;
        player.GetComponent<Player>().moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptMag() //��ź�� �ν�Ʈ
    {
        gun.GetComponent<Gun>().selectSpt = Gun.SelectSpt.MAG;
        player.GetComponent<Player>().moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptRel() //������ �ν�Ʈ
    {
        gun.GetComponent<Gun>().selectSpt = Gun.SelectSpt.REL;
        player.GetComponent<Player>().moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptSpd() //�̵� �ν�Ʈ
    {
        gun.GetComponent<Gun>().selectSpt = Gun.SelectSpt.NON;
        player.GetComponent<Player>().moveSpt = Player.MoveSpt.SPD;
    }
    #endregion

    #region ���� �ý���
    public void BacktoLobby() 
    {
        SceneManager.LoadSceneAsync(0);
        //ó��ȭ������ ���ư��� �޼ҵ�
    }

    public void StartMission() 
    {
        SceneManager.LoadSceneAsync(2);
        //����ȭ������ �̵��ϴ� �޼ҵ�
    }
    #endregion
}
