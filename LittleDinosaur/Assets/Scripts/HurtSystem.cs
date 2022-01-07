using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;  // �ޥ� �ƥ� API

/// <summary>
/// ���˨t��
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    [Header("�ʵe�Ѽ�")]
    public string parameterdead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;

    public Animator ani;
    private float hpMax;

    // ����ƥ�:�b Start ���e����@��
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0)
        {
            Dead();
        }
    }
    private void Dead()
    {
        ani.SetTrigger(parameterdead);
        onDead.Invoke();
    }
}
