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

    #region �ֹ��� ����
    public void selectMainHG() 
    {
        Gun.selectedMain = Gun.SelectedMain.HG;
    }

    public void selectMainSMG()
    {
        Gun.selectedMain = Gun.SelectedMain.SMG;
    }

    public void selectMainAR()
    {
        Gun.selectedMain = Gun.SelectedMain.AR;
    }

    public void selectMainSR()
    {
        Gun.selectedMain = Gun.SelectedMain.SR;
    }

    #endregion

    #region �ι��� ����
    public void selectSubBL()
    {
        Gun.selectedSub = Gun.SelectedSub.BL;
    }

    public void selectSubSG()
    {
        Gun.selectedSub = Gun.SelectedSub.SG;
    }

    public void selectSubGL()
    {
        Gun.selectedSub = Gun.SelectedSub.GL;
    }

    public void selectSubRL()
    {
        Gun.selectedSub = Gun.SelectedSub.RL;
    }

    #endregion

    #region ȸ������ ����

    public void selectDodgeSPR()
    {
        Player.selectDodge = Player.SelectDodge.SPR;
    }

    public void selectDodgeSLD()
    {
        Player.selectDodge = Player.SelectDodge.SLD;
    }

    public void selectDodgeBLK()
    {
        Player.selectDodge = Player.SelectDodge.BLK;
    }

    #endregion

    #region ������� ����
    public void selectSptAtk() //���� �ν�Ʈ
    {
        Gun.selectSpt = Gun.SelectSpt.ATK;
        Player.moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptMag() //��ź�� �ν�Ʈ
    {
        Gun.selectSpt = Gun.SelectSpt.MAG;
        Player.moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptRel() //������ �ν�Ʈ
    {
        Gun.selectSpt = Gun.SelectSpt.REL;
        Player.moveSpt = Player.MoveSpt.NON;
    }

    public void selectSptSpd() //�̵� �ν�Ʈ
    {
        Gun.selectSpt = Gun.SelectSpt.NON;
        Player.moveSpt = Player.MoveSpt.SPD;
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

    private void Start()
    {
    }
}
