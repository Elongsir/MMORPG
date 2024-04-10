using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField UserName;
    public InputField Password;
    public void OnclickLogin()
    {
        if(string.IsNullOrEmpty(UserName.text))
        {
            Debug.Log("�������û���");
            return;
        }
        if (string.IsNullOrEmpty(Password.text))
        {
            Debug.Log("����������");
            return;
        }
        else
        {
            if(GameManager.Instance.VerifyUser(UserName.text, Password.text)!=null) 
            { 
                Debug.Log("��¼�ɹ�");
                GameManager.Instance.LocalUser = GameManager.Instance.VerifyUser(UserName.text, Password.text);
                Debug.LogFormat("�˺ţ�{0}�����룺{1}",GameManager.Instance.LocalUser.UserName,GameManager.Instance.LocalUser.Password);
            }
            else
            {
                Debug.Log("���������˺Ų�����");
            }
        }
    }
    
}
