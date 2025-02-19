using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    { }
    public void OnClickExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;//����Ƽ �÷��� ����
        Application.Quit();//���� �� ���� ����
    }
    public void OnClickReturn()
    { }
}
