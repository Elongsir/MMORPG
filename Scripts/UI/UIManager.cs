using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get { 
            if (instance == null)
            {
                instance = new UIManager();
            }
            return instance; 
        }
    }
    public Dictionary<string, BasePanel> panelDict;
    public Dictionary<string, GameObject> prefebDict;
    public Dictionary<string, string> pathDict;
    private UIManager() { Init(); }
    public void Init() 
    {
        prefebDict = new Dictionary<string, GameObject>();
        panelDict = new Dictionary<string, BasePanel>();
        pathDict = new Dictionary<string, string>()
        {
            {UIConst.UIMessageBox,"UI/loading/MessageBox"},
            { UIConst.UILogin,"UI/loading/Login"},
            {UIConst.UIRegister,"UI/loading/Register" }
        };
    }

    public BasePanel OpenPanel(string name)
    {
        BasePanel panel = null;
        if(panelDict.TryGetValue(name,out panel))
        {
            Debug.Log("界面已打开");
            return null;
        }
        string path = "";
        if(!pathDict.TryGetValue(name, out path))
        {
            Debug.Log("界面名错误或未配置路径:" + name);
            return null;
        }
        GameObject panelprefeb = null;
        if(!prefebDict.TryGetValue(name, out panelprefeb))
        {
            panelprefeb = Resources.Load<GameObject>(path);
            if(panelprefeb==null)
            {
                Debug.Log("配置错误");
            }
            prefebDict.Add(name, panelprefeb);

        }

    }

}
public  class UIConst
{
    public const string UIMessageBox = "MessageBox";
    public const string UILogin = "Login";
    public const string UIRegister = "Register";
}
