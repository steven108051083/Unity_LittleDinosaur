
using UnityEngine;
/// <summary>
/// �ǲ߹B��l
/// 1.���w =
/// 2.�ƾ� + - * / % ���W ++ ���� -- += -= *= /= %=
/// 3.��� > < >= <= ==(����) !=(������)
/// 4.�޿� &&(�åB) ||(�Ϊ�) !(�A��)
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region ���w�B��l
    // ���w�B��l�S��:
    // �� ���w�B��l������k��b���w������
    // 1 + 2 = 3
    public int number = 10;    // ���w:�N�Ʀr 10 ���w����� number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;
    #endregion

    

    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k:" + (numberA + numberB));
        print("��k:" + (numberA - numberB));
        print("���k:" + (numberA * numberB));
        print("���k:" + (numberA / numberB));
        print("�l��:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC ��@:" + numberC);
        numberC--;               // -- �O����
        print("numberC ��@:" + numberC);

        numberD = numberD + 10;
        print("number �[�Q:" + numberD);
        numberD += 10;           // ���W���w �A�Ω�[����l�� += -= *= /= %=
        print("number �[�Q:" + numberD);
        #endregion

        #region ����B��l
        // �@��:�����ӭȡD�åB���o���L�ȵ��G �Ʀr �B�I��...���i
        print("E > F :" + (numberE > numberF));        // t
        print("E < F :" + (numberE < numberF));        // f 
        print("E >= F :" + (numberE >= numberF));      // t 
        print("E <= F :" + (numberE <= numberF));      // f
        print("E == F :" + (numberE == numberF));      // f
        print("E != F :" + (numberE != numberF));      // t 
        #endregion

        #region �޿�B��l
        // �@��:�����ӥ��L�ȡD�åB���o���L�ȵ��G �u��O���L��
        // �åB:�u�n���@�� false ���G�� false
        print("T && T :" + (true && true));            // t
        print("T && F :" + (true && false));           // f
        print("F && T :" + (false && true));           // f
        print("F && F :" + (false && false));          // f
        // �Ϊ�:�u�n���@�� true ���G�� true
        print("T || T :" + (true || true));            // t
        print("T || F :" + (true || false));           // t
        print("F || T :" + (false || true));           // t
        print("F || F :" + (false || false));          // f
        // �A�� !
        // �@��:�N���L�ȵ����ۤ�
        print("!true : " + (!true));
        print("!false : " + (!false));
        #endregion
    }
}

