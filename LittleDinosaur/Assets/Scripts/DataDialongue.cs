using UnityEngine;

// �إ߱M�פ������(menuName = "���W��") ��Ƨ�/�l���
[CreateAssetMenu(menuName = "Steven/��ܸ��")]
/// <summary>
/// ��ܸ��
/// �O�s NPC �n�򪱮a������ܤ��e
/// </summary>
/// Scriptable Object �}���ƪ��� : �N�{������x�s�� Project ��������
public class DataDialongue : ScriptableObject
{
    // TextArea (�̤p���, �̤j���) - �ȭ� string �ϥ�
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues;
}
