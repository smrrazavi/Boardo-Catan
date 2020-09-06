﻿using UnityEngine;

public class Road : MonoBehaviour
{
    private int _builtID = -1;
    [SerializeField] private Settlement s1, s2;
    
    private void OnMouseDown()
    {
        //todo: check road bought
        if (!MainScreen.ShouldRoadClickable) return;
        if (_builtID != -1) return;
        _builtID = MainScreen.ThisPlayerID;
        ChangeRoadColor();
        Debug.Log(gameObject.name);
        MainScreen.ShouldRoadClickable = true;
    }

    private void ChangeRoadColor()
    {
        var road = GetComponent<SpriteRenderer>();
        road.color = MainScreen.ThisPlayerColor;
    }
}