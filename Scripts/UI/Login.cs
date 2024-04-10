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
            Debug.Log("请输入用户名");
            return;
        }
        if (string.IsNullOrEmpty(Password.text))
        {
            Debug.Log("请输入密码");
            return;
        }
        else
        {
            if(GameManager.Instance.VerifyUser(UserName.text, Password.text)!=null) 
            { 
                Debug.Log("登录成功");
                GameManager.Instance.LocalUser = GameManager.Instance.VerifyUser(UserName.text, Password.text);
                Debug.LogFormat("账号：{0}，密码：{1}",GameManager.Instance.LocalUser.UserName,GameManager.Instance.LocalUser.Password);
            }
            else
            {
                Debug.Log("密码错误或账号不存在");
            }
        }
    }
    
}
