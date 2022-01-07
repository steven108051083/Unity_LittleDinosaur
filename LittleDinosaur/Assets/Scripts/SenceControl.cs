using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceControl : MonoBehaviour
{
   public void LoadScence(string nameScence)
    {
        SceneManager.LoadScene(nameScence);
    }
    public void Quit()
    {
        Application.Quit();    // 離開應用程式
        print("關閉遊戲");
    }
}
