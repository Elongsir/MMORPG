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
            Debug.Log("�������˺�");
            return;
        }
        if(string.IsNullOrEmpty(Password.text))
        {
            Debug.Log("����������");
            return;
        }
        if(string.IsNullOrEmpty(RePassWord.text))
        {
            Debug.Log("���ظ�����");
            return;
        }
        if(Password.text!=RePassWord.text)
        {
            Debug.Log("�������� ���벻һ��");
        }
        else
        {
            if(GameManager.Instance.VerifyUser(UserName.text, Password.text)!=null)
            {
                Debug.Log("�˺��Ѵ���");
            }
            else
            {
                if(GameManager.Instance.CreatUser(UserName.text, Password.text)==true)
                {
                    Debug.Log("ע��ɹ�");
                    return;
                }
                Debug.Log("ע��ʧ��");



            }
            ;
            
        }
    }
}
