
using UnityEngine;
/// <summary>
/// 學習運算子
/// 1.指定 =
/// 2.數學 + - * / % 遞增 ++ 遞減 -- += -= *= /= %=
/// 3.比較 > < >= <= ==(等於) !=(不等於)
/// 4.邏輯 &&(並且) ||(或者) !(顛倒)
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region 指定運算子
    // 指定運算子特性:
    // ※ 指定運算子先執行右邊在指定給左邊
    // 1 + 2 = 3
    public int number = 10;    // 指定:將數字 10 指定給欄位 number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;
    #endregion

    

    private void Start()
    {
        #region 數學運算子
        print("加法:" + (numberA + numberB));
        print("減法:" + (numberA - numberB));
        print("乘法:" + (numberA * numberB));
        print("除法:" + (numberA / numberB));
        print("餘數:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC 減一:" + numberC);
        numberC--;               // -- 是遞減
        print("numberC 減一:" + numberC);

        numberD = numberD + 10;
        print("number 加十:" + numberD);
        numberD += 10;           // 遞增指定 適用於加減乘除餘數 += -= *= /= %=
        print("number 加十:" + numberD);
        #endregion

        #region 比較運算子
        // 作用:比較兩個值．並且取得布林值結果 數字 浮點數...都可
        print("E > F :" + (numberE > numberF));        // t
        print("E < F :" + (numberE < numberF));        // f 
        print("E >= F :" + (numberE >= numberF));      // t 
        print("E <= F :" + (numberE <= numberF));      // f
        print("E == F :" + (numberE == numberF));      // f
        print("E != F :" + (numberE != numberF));      // t 
        #endregion

        #region 邏輯運算子
        // 作用:比較兩個布林值．並且取得布林值結果 只能是布林值
        // 並且:只要有一個 false 結果為 false
        print("T && T :" + (true && true));            // t
        print("T && F :" + (true && false));           // f
        print("F && T :" + (false && true));           // f
        print("F && F :" + (false && false));          // f
        // 或者:只要有一個 true 結果為 true
        print("T || T :" + (true || true));            // t
        print("T || F :" + (true || false));           // t
        print("F || T :" + (false || true));           // t
        print("F || F :" + (false || false));          // f
        // 顛倒 !
        // 作用:將布林值給為相反
        print("!true : " + (!true));
        print("!false : " + (!false));
        #endregion
    }
}

