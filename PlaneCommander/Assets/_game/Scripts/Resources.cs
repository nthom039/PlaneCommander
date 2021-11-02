using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    public int planes = 1;
    public int brick = 0;
    public int metal = 0;
    public int friendliness = 50;

    [SerializeField]private Text planesText;
    [SerializeField]private Text brickText;
    [SerializeField]private Text metalText;
    [SerializeField]private Text friendlinessText;

    public void Start()
    {
        PlaneUpdate();
        BrickUpdate();
        MetalUpdate();
        FriendlinessUpdate();
    }

    public void PlaneUpdate()
    {
        planesText.text = "Planes: " + planes;
    }

    public void BrickUpdate()
    {
        brickText.text = "Brick: " + brick;
    }

    public void MetalUpdate()
    {
        metalText.text = "Metal: " + metal;
    }

    public void FriendlinessUpdate()
    {
        friendlinessText.text = "Friendliness: " + friendliness;
    }
}
