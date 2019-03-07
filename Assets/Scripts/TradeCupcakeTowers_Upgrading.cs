﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TradeCupcakeTowers_Upgrading : TradeCupcakeTowers {


    // Update is called once per frame
    void Update() {
        /*
        if (currentActiveTower == null) {
            gameObject.SetActive(false);
        }
        else {
            gameObject.SetActive(true);
        }
        */
    }

    public override void OnPointerClick(PointerEventData eventData) {

        //Check if there is a tower selected before to proceed
        if (currentActiveTower == null)
            return;

        //Check if the player can afford to upgrade the tower
        if (currentActiveTower.isUpgradable && currentActiveTower.upgradingCost <= sugarMeter.getSugarAmount()) {
            //The payment is executed and the sugar removed from the player
            sugarMeter.ChangeSugar(-currentActiveTower.upgradingCost);
            //The tower is upgraded
            currentActiveTower.Upgrade();
        }
    }

}
