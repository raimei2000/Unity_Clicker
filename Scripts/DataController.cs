using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController instance;
    
    public static DataController GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<DataController>();
            // Scene을 다 뒤져서 DataController 타입의 오브젝트를 찾아냄
            if(instance == null)
            {
                GameObject container = new GameObject("DataController");

                instance = container.AddComponent<DataController>();
            }
        }
        return instance;
    }


    private int m_gold = 0;
    private int m_goldPerClick = 0;

    void Awake() // 게임이 처음 시작되면 실행
    {
        // PlayerPref에서 key : value 형태로 저장된 값을 가져옴
        // 해당 key값이 없으면 value를 0으로 가져옴
        // setter도 있음
        m_gold = 0; // PlayerPrefs.GetInt("Gold");
        m_goldPerClick = 1; // PlayerPrefs.GetInt("GoldPerClick", 1);
        // 아무런 값이 없으면 default로 1가져와라
    }

    public void SetGold(int newGold)
    {
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold);
    }

    public void AddGold(int newGold)
    {
        m_gold += newGold;
        SetGold(m_gold);
    }

    public void SubGold(int newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }

    public int GetGold()
    {
        return m_gold;
    }

    public int GetGoldPerClick()
    {
        return m_goldPerClick;
    }

    public void SetGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);
    }

    public void AddGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick += newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }
}
