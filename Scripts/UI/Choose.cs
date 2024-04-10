using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Choose : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    private Animator ani;
    private void Start()
    {
        ani = this.GetComponent<Animator>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        InAni();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ExitAni();
    }
    private void InAni()
    {
        ani.SetTrigger("In");
    }
    private void ExitAni()
    {
        ani.SetTrigger("Exit");
    }
}
