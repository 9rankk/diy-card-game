using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class show_card : MonoBehaviour
{
    public card item;
    public Image show_photos;
    public Text number_text;
    
    
    public void show()
    {   
        /*if(!((item is Foundation_card)||(item is Function_card)))
        {
            number_text.gameObject.SetActive(false);
        }
        else if (item is Foundation_card) {
            var function_card = item as Function_card;
            number_text.text = function_card.number.ToString();
        }
        else if (item is Function_card)
        {
            var function_card = item as Function_card;
            number_text.text = function_card.number.ToString();
        }*/
        number_text.text = "4";
        
    }

    // Start is called before the first frame update
    void Start()
    {
        show();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
