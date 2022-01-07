using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵人行為
/// 檢測目標物件是否再追蹤區域
/// 追蹤與攻擊目標
/// </summary>
public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    [Header("動畫參數")]
    public string parameterWalk = "開關_走路";
    public string parameterAttack = "觸發攻擊";

    private Rigidbody2D rig;
    private Animator ani;
    [Header("面向目標物件")]
    public Transform target;
    [Header("攻擊距離"), Range(0, 5)]
    public float attackDistaance = 1.3f;
    [Header("攻擊冷卻時間"), Range(0, 10)]
    public float attackCD = 2.0f;
    [Header("檢查攻擊區域大小與位移")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 35;
    private float angle = 0;
    private float timerAttack;
    #endregion

    #region 事件
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OnDrawGizmos()
    {
        // 指定圖示顏色
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // 繪製立方體(中心,尺寸)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }
    #endregion
    #region 方法
    /// <summary>
    /// 檢查目標是否在區域內
    /// </summary>
    private void CheckTargetInArea()
    {
        // 2D 物理覆蓋盒形(中心， 尺寸， 角度)
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);
        if (hit)
        {
            Move();
        }
        else
        {
            ani.SetBool(parameterWalk, false);
        }
    }
    

    private void Move()
    {
        // 三元運算子語法 : 布林值 ? 當布林值 為true : 當布林值 為flase ;
        // 如果 目標的 x 小於 敵人的 x 就代表在左邊 角度 0
        // 如果 目標的 x 大於 敵人的 x 就代表在右邊 角度 180
        if (target.position.x > transform.position.x)
        {
             //angle = 180;
        }
        else if (target.position.x < transform.position.x)
        {
             //angle = 0;
        }
        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));

        ani.SetBool(parameterWalk, true);

        // 距離 = 三維向量.距離(A點，B點)
        float distance = Vector3.Distance(target.position, transform.position);
        print("與目標距離:" + distance);

        if (distance <= attackDistaance)  // 如果 距離 小於攻擊距離
        {
            rig.velocity = Vector3.zero;  // 停止
            Attack();
        }
    }
    private void Attack()
    {
        if (timerAttack < attackCD)       // 如果 計時器 小於 冷卻時間
        {
            timerAttack += Time.deltaTime;    // 時間累加 Time.deltaTime 一幀的時間
        }
        else
        {
            ani.SetTrigger(parameterAttack);
            timerAttack = 0;
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize, 0, layerTarget);
            print("攻擊到物件:" + hit.name);
            hit.GetComponent<HurtSystem>().Hurt(attack);
        }
    }
    #endregion
}


