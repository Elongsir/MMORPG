using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel:MonoBehaviour
    {
        protected bool IsRemove=false;
        protected new string name;
        public virtual void OpenPanel(string name)
        {
            this.name=name;
           this.gameObject.SetActive(true);
        }
    public virtual void ClosePanel() 
    {
        
    }
    }

