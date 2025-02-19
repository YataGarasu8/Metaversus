using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void OnClickStart()
    { SceneManager.LoadScene("GameScene"); }
    public void OnClickExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;//유니티 플레이 종료
        Application.Quit();//빌드 된 게임 종료
    }
    public void OnClickReturn()
    { SceneManager.LoadScene("MainScene"); }
}
