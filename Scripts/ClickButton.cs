using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public DataController dataController;
    public void OnClick()
    {
        dataController.AddGold(dataController.GetGoldPerClick());
    }
}
