using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInstance : MonoBehaviour
{
    public Image image;//获取图片组件，设置图片
    public Image SmallImage;
    public Sprite[] img;//获取Prefab上绑定过的指定的图片
    public Sprite[] smallImg;
    public Card card;//确认这张牌
    public Text Title;
    public Text CardInfo;
    public int CardID;//用一个ID来设计卡牌的功能（抽象事件牌技能）

    // Start is called before the first frame update
    void Start()
    {
        //设置卡牌文字信息
        //Invoke("DelaySetInfor", 0.5f);
    }

    private void DelaySetInfor()
    {
        //Title.text = card.CardTitle;
        //CardInfo.text = card.CardInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCard(Card card)
    {



        this.card = card;


    }
}
