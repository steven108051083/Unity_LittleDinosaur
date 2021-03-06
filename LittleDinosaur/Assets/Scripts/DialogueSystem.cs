using UnityEngine;
using UnityEngine.UI;      // 需要使用 UI 介面 
using System.Collections;

/// <summary>
/// 對話系統
/// 將需要輸出的文字利用打字效果呈現
/// </summary>

public class DialogueSystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
        // StartCoroutine(TypeEffect());
    }

    /// <summary>
    /// 打字效果
    /// </summary>
    /// <param name="contents">想要出現在對話系統的對話內容 需使用字串陣列</param>
    private IEnumerator TypeEffect(string[] contents)
    {
        // 更換名稱快捷鍵 Ctrl + R R
        // 測試用
        // string test1 = "哈嘍，你好";
        // string test2 = "對話第二段";
        // string[] test = { test1, test2 };

        goDialogue.SetActive(true);   // 顯示對話物件

        for (int j = 0; j < contents.Length; j++)
        {
            textContent.text = "";        // 清除上次對話內容
            goTip.SetActive(false);  // 隱藏 提示圖示 三角形
            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];  // 疊加對話內容到文字界面
                yield return new WaitForSeconds(interval);
            }
            
            goTip.SetActive(true);
            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;
            }
            textContent.text = "";
        }
            goDialogue.SetActive(false);
        
    }
    /// <summary>
    /// 開始對話
    /// </summary>
    /// <param name="contents">要顯示打字效果的對話內容</param>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }
    /// <summary>
    /// 停止對話
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();  // 停止協同程序
        goDialogue.SetActive(false);  // 隱藏對話介面
    }
}
