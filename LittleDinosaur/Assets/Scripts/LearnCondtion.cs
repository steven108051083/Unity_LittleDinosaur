using UnityEngine;

public class LearnCondtion : MonoBehaviour
{
    public bool openDoor;
    public int scare = 70;
    public string weapon = "�M�l";

    // �}�l�ƥ�:����ɰ���@��
    private void Start()
    {
        #region �P�_�y if
        // �y�k:
        // ���L�Ȭ� true �ɷ|���� if �� {}
        // ���L�Ȭ� false �ɷ|���� else �� {}
        // if (���L��) { �{�����e }
        if (true)
        {
            print("�{�ѧP�_�� if");
        }

        // if (���L��) { �{�����e }
        // else { �{�����e } (�_�h)
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
        #endregion
    }

    // ��s�ƥ�:���@���Q����s (60 fps)
    private void Update()
    {
        print("�������");

        #region �P�_�� if
        // �_�h �p�G else if (���L��) { �{�����e } - if�U�� else�W�� - �L�ƶq����
        // �p�G ���� >= 60 �ή�
        // �p�G ���� <= 60 ���O >= 40 �ɦ�
        // �_�h �N ���ή�
        if (scare >= 60) 
        {
            print("�ή�");
        }
        else if (scare >= 40)
        {
            print("�ɦ�");
        }
        else if (scare >= 30)
        {
            print("��");
        }
        else
        {
            print("���ή�");
        }
        #endregion

        #region �P�_�� switch
        // switch (��) 
        // {
        //    case "�M�l":
        //       �����O 10;
        //       break;
        //    case "�����j":
        //       �����O 1000;
        //       break;
        //    default:          (����b�̤U��)
        //       �o���O�Z��;
        //       break;
        // }

        switch (weapon)
        {
            case "�M�l":
                print("�����O 10");
                break;
            case "�����j":
                print("�����O 1000");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
        #endregion
    }
}
