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
