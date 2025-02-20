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
    }
    public void RunTime(float time)
    {
        if (time > 0)
        {
            GameManager.gameManager.runTime -= Time.deltaTime;
        }
        else
        {
            GameManager.gameManager.runTime = 0f;
        }
        timeText.text = time.ToString("N2");
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene("GameScene"); 
    }
    public void OnClickExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;//����Ƽ �÷��� ����
        Application.Quit();//���� �� ���� ����
    }
    public void OnClickReturn()
    { 
        SceneManager.LoadScene("MainScene"); 
    }
}
