using UnityEngine;     // 引用 Unity 引擎命名空間:可以使用此空間的 API

// 單行註解
// Class 類別:一個物件的藍圖
// 語法:類別 類別名稱 { 類別內容 (類別成員) }
// 此類別要在 Unity 內使用必須繼承 MonoBehaviour
// 括號皆是成對出現:()、[]、{}、<>、''、""
// 語法的結束符號以 ; 為一個語法的結束 成功定義一筆資料 字串打在""裡面
public class Car : MonoBehaviour
{
    #region 欄位語法及四大常用類型
    // 欄位 Field:保存各種類型的資料 欄位是小寫開頭 欄位的名稱通常是英文 
    // 語法: 修飾詞 資料類型 欄位名稱 指定 (=) 預設值 結束符號
    // ※ 四大常用類型:
    // 整  數:儲存沒有小數點的正負整數 - int
    // 浮點數:儲存帶有小數點的正負整數 - float
    // 字  串:儲存文字資訊            - string
    // 布林值:是與否 true、false      - bool
    // ※ 修飾詞
    // 私人:其他類別不能存取、不顯示 private (預設值)
    // 公開:其他類別可以存取、顯  示 publiv
    // 欄位屬性 Attritube 
    // 語法:[屬性名稱(值)]
    // 1. 標題 Header(字串)         屬性面版上會出現說明
    // 2. 提示 Tooltip(字串)        滑鼠停留在屬性上會出現提示
    // 3. 範圍 Range(最小值、最大值) 屬性面板上會出現滑桿可以控制屬性 - 僅適用於數值類型 int、float
    [Header("cc 數"), Range(500, 5000)]
    public int cc = 1000;
    [Header("重量"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("品牌名稱"), Tooltip("這是車子品牌名稱")]
    public string brand = "賓士";
    [Header("是否有天窗")]
    public bool hasSkyWindow = true;
    #endregion

    #region Unity 內資料類型
    // 顏色 向量 (座標)、按鍵、遊戲物件、元件
    // 顏色 Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    // 向量 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // 按鍵 Keycode Mouse0 滑鼠左鍵 Mouse1 滑鼠右鍵 Mouse2 滑鼠滾輪
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    // 遊戲物件 GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // 元件 Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region 事件:程式的入口
    // 開始事件:遊戲撥放時執行一次
    private void Start()
    {
        // 呼叫方法:方法名稱();
        Test();
        Drive80();
        Drive100();
        Drive(120);      //呼叫時填入的稱為引數
        Drive(990);
        float w99 = ConvertWeight(9.9f);
        print("9.9 轉換:" + w99);

        print("重量轉換:" + ConvertWeight(weight));
    }
    #endregion

    #region 方法語法
    // 方法:保存程式內容的區塊(演算法、陳述式)
    // 語法:修飾詞 傳回類型 方法名稱 (參數1,參數2,參數n) {程式內容}
    // void 無傳回:使用方法時不會有傳回資料
    // 自訂方法:不會執行,必須呼叫才會執行
    // 定義的時候小括號裡面的叫參數 呼叫的時候小括號裡面的叫引數
    private void Test()
    {
        // 輸出(訊息) - 將訊息輸出至 Unity 儀錶板 Console
        print("哈囉.沃德 :D");
    }

    private void Drive80()
    {
        print("開車時速:" + 80);
        print("音效:咻咻咻");
    }

    private void Drive100()
    {
        print("開車時速:" + 100);
        print("音效:咻咻咻");
    }

    //參數語法:資料類型 參數名稱
    private void Drive(int speed)
    {
        print("開車時速:" + speed);
        print("音效:咻咻咻");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}