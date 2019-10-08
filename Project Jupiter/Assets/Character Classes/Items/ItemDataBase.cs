using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class ItemDataBase : MonoBehaviour
{
    public TextAsset ItemInvetory;
    public static List<BaseStatItem> itemInventory = new List<BaseStatItem>();

    private List<Dictionary<string, string>> InvintoryItemDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> InventoryDictionary;

    public void ReadItemsFromDataBase()
    {

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(ItemInvetory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("ITEAMS");



        foreach (XmlNode iteminfo in itemList)
        {
            XmlNodeList itemContent = iteminfo.ChildNodes;
            InventoryDictionary = new Dictionary<string, string>();
            foreach(XmlNode content in itemContent)
            {
                switch (content.Name)
                {
                    case "ItemName":
                        
                            InventoryDictionary.Add("ItemName", content.InnerText);
                            break;
                        
                    case "ItemID":
                        InventoryDictionary.Add("ItemID", content.InnerText);
                        break;
                    case "ItemType":
                        InventoryDictionary.Add("ItemType", content.InnerText);
                        break;
                }

            }

            InvintoryItemDictionary.Add(InventoryDictionary);

        }
    }
        
        
        
}
