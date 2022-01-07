using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;  // 引用 事件 API

/// <summary>
/// 受傷系統
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    [Header("動畫參數")]
    public string parameterdead = "觸發死亡";
    [Header("死亡事件")]
    public UnityEvent onDead;

    public Animator ani;
    private float hpMax;

    // 喚醒事件:在 Start 之前執行一次
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收到的傷害</param>
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
