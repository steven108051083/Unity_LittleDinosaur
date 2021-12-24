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
    public string parameterWalk = "開關走路";

    private Rigidbody2D rig;
    private Animator ani;
    [Header("面向目標物件")]
    public Transform target;

    private float angle = 0;
    #endregion

    #region 事件
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);
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
            // 右邊 angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
            // 左邊 angle = 0
        }
        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));

        ani.SetBool(parameterWalk, true);

        // 距離 = 三維向量.距離(A點，B點)
        float distance = Vector3.Distance(target.position, transform.position);
        print("與目標距離:" + distance);
    }
    #endregion
}


