using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI pointText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI bestPointText;
    public TextMeshProUGUI nowPointText;

    int bestPoint;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void UpdatePoint(int point)
    {
        pointText.text = point.ToString();
        nowPointText.text = point.ToString();
       if (point > bestPoint)
        {
            bestPoint = point;
            bestPointText.text = bestPoint.ToString();
        }
    }
    public void RunTime(float time)
    {
        if (time > 0)
        {
            GameManager.instance.runTime -= Time.deltaTime;
        }
        else
        {
            GameManager.instance.runTime = 0f;
            GameManager.instance.GameOver();
        }
        timeText.text = time.ToString("N2");
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene("GameScene"); 
    }
    public void OnClickExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;//유니티 플레이 종료
        Application.Quit();//빌드 된 게임 종료
    }
    public void OnClickReturn()
    { 
        SceneManager.LoadScene("MainScene"); 
    }
}
