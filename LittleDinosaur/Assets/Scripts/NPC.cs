using UnityEngine;

/// <summary>
/// NPC 行為
/// 偵測目標進入碰撞區
/// 顯示對話系統
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDialongue dataDialongue;
    [Header("對話系統")]
    public DialogueSystem dialogueSystem;
    [Header("觸發對話的對象")]
    public string target = "小恐龍";
    public KeyCode keyDialogue = KeyCode.Space;

    // 觸發開始事件
    // 1. 兩個物件都要有 Collider 2D
    // 2. 兩個其中一個要有 Rigidbody 2D
    // 3. 兩個其中一個要勾 is Trigger
    // OnTriggerEnter2D 物件進入觸發
    // OnTriggerExit2D 物件離開觸發
    // OnTriggerStay2D 物件持續觸發
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
