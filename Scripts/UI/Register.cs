using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField UserName;
    public InputField Password;
    public InputField RePassWord;
    public void OnClickRegister()
    {
        if(string.IsNullOrEmpty(UserName.text))
        {
            Debug.Log("请输入账号");
            return;
        }
        if(string.IsNullOrEmpty(Password.text))
        {
            Debug.Log("请输入密码");
            return;
        }
        if(string.IsNullOrEmpty(RePassWord.text))
        {
            Debug.Log("请重复密码");
            return;
        }
        if(Password.text!=RePassWord.text)
        {
            Debug.Log("两次密码 输入不一样");
        }
        else
        {
            if(GameManager.Instance.VerifyUser(UserName.text, Password.text)!=null)
            {
                Debug.Log("账号已存在");
            }
            else
            {
                if(GameManager.Instance.CreatUser(UserName.text, Password.text)==true)
                {
                    Debug.Log("注册成功");
                    return;
                }
                Debug.Log("注册失败");



            }
            ;
            
        }
    }
}
