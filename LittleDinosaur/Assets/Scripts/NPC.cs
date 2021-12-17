using UnityEngine;

/// <summary>
/// NPC �欰
/// �����ؼжi�J�I����
/// ��ܹ�ܨt��
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialongue dataDialongue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�p���s";
    public KeyCode keyDialogue = KeyCode.Space;

    // Ĳ�o�}�l�ƥ�
    // 1. ��Ӫ��󳣭n�� Collider 2D
    // 2. ��Ө䤤�@�ӭn�� Rigidbody 2D
    // 3. ��Ө䤤�@�ӭn�� is Trigger
    // OnTriggerEnter2D ����i�JĲ�o
    // OnTriggerExit2D �������}Ĳ�o
    // OnTriggerStay2D �������Ĳ�o
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StartDialogue(dataDialongue.dialogues);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StopDialogue();
        }
    }
}
