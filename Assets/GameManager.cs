using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CanvasGroup inventoryCG;
    


    public static GameManager instance = null;


    // Start is called before the first frame update
    void Start()
    {
        
        OnInventoryOpen(false);
    }

 



    public void OnInventoryOpen(bool isOpend)
    {
        inventoryCG.alpha = (isOpend) ? 1.0f : 0.0f;
        inventoryCG.interactable = isOpend;
        inventoryCG.blocksRaycasts = isOpend;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
