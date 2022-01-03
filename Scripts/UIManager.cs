using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public Text goldPerClickDisplayer;
    public DataController dataController;

    void Update()
    {
        goldDisplayer.text = "GOLD: " + dataController.GetGold();
        goldPerClickDisplayer.text = "GOLD PER CLICK: " + dataController.GetGoldPerClick();
    }
}
