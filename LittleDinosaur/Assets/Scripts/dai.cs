using UnityEngine;
/// <summary>
///  控制器 : 2D 橫向卷軸版本
/// </summary>

public class dai : MonoBehaviour
{
    #region 欄位 : 公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 500;
    [Header("檢查地板尺寸與位移"), Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion
    /// <summary>
    ///  剛體元件
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    ///  繪製圖示
    ///  在 Unity 繪製輔助用的圖示
    ///  線條、射線、圓形、方形、扇形、圖片
    /// </summary>
    private void OnDrawGizmos()
    {
        // 1. 決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2. 決定繪製圖形 
        // transform.position 此物件的世界座標
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    /// <summary>
    ///  Update 約 60 FPS
    ///  固定更新事件 : 50 FPS
    ///  處理物件行為建議用固定更新事件 FixedUpdate
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        Filp();
    }
    #region 方法
    /// <summary>
    /// 物件移動 (API)
    /// </summary>
    private void Move()
    {
        // h 值 指定為 輸入.取得軸向(水平軸) - 水平軸代表角色左右移動
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值" + h);

        // 剛體元件 加速度 = 新 二維向量(h值 * 移動速度, 剛體.加速度.垂直);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }
    /// <summary>
    ///  翻面:
    ///  h 值 小於 0 左:角度 Y 180
    ///  h 值 大於 0 右:角度 Y 0
    /// </summary>
    private void Filp()
    {
        float h = Input.GetAxis("Horizontal");

        // 如果 h 值 小於 0 左: 角度 Y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        // 如果 h 值 大於 0 右: 角度 Y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
    #endregion

}
