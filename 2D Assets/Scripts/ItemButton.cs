﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public int ButtonID;
    private Item thisItem;
    private Item GetThisItem(){
        for (int i = 0; i < GameManager.instance.items.Count; i++){
            if (ButtonID == i){
                thisItem = GameManager.instance.items[i];
            }
        }
       return thisItem;
    }
    public void CloseButton(){
        GameManager.instance.RemoveItem(GetThisItem());
    }
}
