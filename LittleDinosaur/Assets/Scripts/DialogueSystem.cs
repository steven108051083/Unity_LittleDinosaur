using UnityEngine;
using UnityEngine.UI;      // �ݭn�ϥ� UI ���� 
using System.Collections;

/// <summary>
/// ��ܨt��
/// �N�ݭn��X����r�Q�Υ��r�ĪG�e�{
/// </summary>

public class DialogueSystem : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }
    private IEnumerator TypeEffect()
    {
        string test = "���ơA�A�n";

        textContent.text = "";        // �M���W����ܤ��e
        goDialogue.SetActive(true);   // ��ܹ�ܪ���

        for (int i = 0; i < test.Length; i++)
        {
            textContent.text += test[i];  // �|�[��ܤ��e���r�ɭ�
            yield return new WaitForSeconds(interval);
        }
    }
}
