using UnityEngine;

/// <summary>
/// �ǲ߰j��  �j��n�bstart�̨ϥ� �bupdate�̨ϥη|���(�L���j��)
/// 1. while *
/// 2.do while
/// 3.for *
/// 4.foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // �ݨD:
        // ��X�Ʀr1~10
        print("�Ʀr:" + 1);
        print("�Ʀr:" + 2);
        print("�Ʀr:" + 3);
        print("�Ʀr:" + 4);
        print("�Ʀr:" + 5);
        print("�Ʀr:" + 6);
        print("�Ʀr:" + 7);
        print("�Ʀr:" + 8);
        print("�Ʀr:" + 9);
        print("�Ʀr:" + 10);

        // �j��@��:
        // ���ư���ۦP�{���åB�i�H���w����

        #region whike �j��
        // �y�k
        // while (���L��) { �{�����e }
        // �S��: �� ���L�� �� true �ɷ|������� {} ���쥬�L�� �� false
        int i = 1;
        while (i < 11)
        {
            print("while �j��:" + i);
            i++;
        }
        #endregion

        #region for �j��
        // �y�k
        // for (��l�� ; ���L�� ; �j�鵲����n���檺�{��) { �{�����e }
        for (int j = 1; j < 11; j++)
        {
            print("for �j��:" + j);
        }
        #endregion

    }
}
