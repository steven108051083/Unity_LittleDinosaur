using UnityEngine;

/// <summary>
/// 學習陣列 Array
/// </summary>
public class LearnArray : MonoBehaviour
{
    #region 陣列
    // 三個道具的價格:100, 200, 300
    public int priceA = 100;
    public int priceB = 200;
    public int priceC = 300;

    // 陣列特性:儲存相同資料類型 (整數、浮點數、字串、顏色...)
    // 語法:
    // 修飾詞 資料類型[] 陣列名稱 指定 值;
    public int[] pricese;

    // 陣列初始值
    // 第一種:指定陣列數量
    public int[] scores = new int[5];
    // 第二種:指定陣列值
    public string[] props = { "紅水", "藍水", "黃水" };

    public int[] levels = new int[10];

    private void Start()
    {
        // 取得陣列資料 Get
        // 語法:陣列名稱[編號] - 編號從零開始 ***
        print("第三筆道具:" + props[2]);
        // 設定陣列資料 Set
        // 語法:陣列名稱[編號] 指定 值;
        props[1] = "鑰匙";
        print("第二筆道具:" + props[1]);

        // 陣列數量
        print("等級陣列的數量:" + levels.Length);

        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = (i + 1);
        }
    }
    #endregion
}
