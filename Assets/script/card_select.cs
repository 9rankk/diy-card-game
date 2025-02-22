using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class card_up : MonoBehaviour,IPointerClickHandler
{
   

    #region 是否被选中（选中者，打标签并上浮）
    private void change_tag()
    {
        if (this.tag=="card_selected") {
            this.tag = "Untagged";
            return;
        }
        else
        {
            this.tag = "card_selected";
            return;
        }
    }
    public void OnPointerClick(PointerEventData click)//点击实体的时候，改变_tag标签然后根据标签决定上移，还是下移
    {
        change_tag();
        if(this.tag== "card_selected")
        this.transform.Translate(Vector3.up * 40f);
        else
            this.transform.Translate(Vector3.down * 40f);
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
