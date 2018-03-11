﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] heartSprites;
    public Image heartUI;
    private Player player;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	void Update () {
        heartUI.sprite = heartSprites[player.curHealth];
	}
}
