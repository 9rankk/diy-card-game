using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class card_center : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    #region 增加增加子个体 add_card(<对象><数量><子个体>)
    private void add_card(GameObject it, int n, GameObject p)
    {

        GameObject child;
        for (int i = 0; i < n; i++)
        {
            if (it == null || p == null)
            {
                Debug.Log("被添加子个体/子个体 不存在");
                continue;
            }
            child = Instantiate(p);
            child.transform.SetParent(it.transform);

        }
    }
    #endregion
    #region 读取子个体数量check_number_of_card(Gameobject <target>),返回int
    private int check_number_of_children(GameObject target)
    {
        if (target == null)
        {
            Debug.Log("读取目标为空");
            return -1;
        }
        int number = target.transform.childCount;
        return number;
    }
    #endregion
    #region 打出卡牌 pause_card() 找到标签为card_selected 并删除(后续效果待开发)
    public void pause_card()//打出卡片
    {
        GameObject[] card_pause = GameObject.FindGameObjectsWithTag("card_selected");
        foreach (GameObject it in card_pause)
        {
            if (it != null)
                Destroy(it);
        }
    }
    #endregion
    #region 初始化所有卡牌为未选中状态 card_init()
    public void card_init()
    {
        GameObject[] target = GameObject.FindGameObjectsWithTag("card_selected");
        foreach (GameObject it in target)
        {
            if (it.tag == "card_selected")
            {
                it.transform.Translate(Vector3.down * 40f);
            }
            it.tag = "Untagged";
        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        card_init();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
