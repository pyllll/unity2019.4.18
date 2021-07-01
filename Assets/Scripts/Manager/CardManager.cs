using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    [SerializeField]
    private GameObject CardPrefeb;//持有卡牌Prefab

    // Start is called before the first frame update
    void Start()
    {
        //GameObject Card = (GameObject)Instantiate(CardPrefeb, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatCard(int Rand)
    {
        Card card1 = new Card(1, "testCard", "damage 5!");
        //实例化Prefab,实例化时CardInstance调用Start()函数生成文字信息，SetImage生成图片信息
        GameObject gotest = new GameObject("23");
        
        GameObject Card =(GameObject)Instantiate(CardPrefeb, transform.position, transform.rotation);
        //SendMessage给预物体的脚本，完成更换贴图以及具化卡牌的功能  
        Card.GetComponent<CardInstance>().SetCard(card1);

        Debug.Log(Rand);
        Debug.Log(card1.CardInfo);

        //设置卡牌底图    
        //Card.GetComponent<CardInstance>().SetImage(CardGroup[Rand].ImageIndex);
        //Card.GetComponent<CardInstance>().SetAtk(CardGroup[Rand].Demage);

        //Card.GetComponent<Transform>().SetParent(GameObject.Find("Canvas").GetComponent<Transform>());
        //Card.GetComponent<RectTransform>().DOAnchorPos3D(new Vector3(-340 + i * 180, -240, 0), 3f);
        //Card.GetComponent<Transform>().SetSiblingIndex(0);
    }


}
