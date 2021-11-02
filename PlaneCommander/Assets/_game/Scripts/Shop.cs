using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject resourcePanel;
    public GameObject buildTowerMenu;

    public void BuildPlane()
    {
        if(resourcePanel.GetComponent<Resources>().metal >= 15)
        {
            resourcePanel.GetComponent<Resources>().planes ++;
            resourcePanel.GetComponent<Resources>().PlaneUpdate();
            resourcePanel.GetComponent<Resources>().metal -= 15;
            resourcePanel.GetComponent<Resources>().MetalUpdate();
        }
    }

    public void GetBricks()
    {
        resourcePanel.GetComponent<Resources>().brick += 5;
        resourcePanel.GetComponent<Resources>().BrickUpdate();
    }

    public void GetMetal()
    {
        resourcePanel.GetComponent<Resources>().metal += 5;
        resourcePanel.GetComponent<Resources>().MetalUpdate();
    }

    public void HelpCountry()
    {
        resourcePanel.GetComponent<Resources>().friendliness += 15;
        resourcePanel.GetComponent<Resources>().FriendlinessUpdate();
    }

    public void BuildTower()
    {
        Time.timeScale = 0f;
        buildTowerMenu.SetActive(true);
    }
}
