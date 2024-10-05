using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BtnType
{
    New,
    Continue,
    Option,
    Quit
}
public class BtnManager : MonoBehaviour
{
    public BtnType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BtnType.New:
                Debug.Log("�� ����");
                SceneManager.LoadScene("MainScene");
                break;
            case BtnType.Continue:
                Debug.Log("�̾��ϱ�");
                SceneManager.LoadScene("MainScene");
                break;
            case BtnType.Option:
                Debug.Log("����");
                break;
            case BtnType.Quit:
                Debug.Log("���� ����");
                Application.Quit();
                break;
        }
    }
}
