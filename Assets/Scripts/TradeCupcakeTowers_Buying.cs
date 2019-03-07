using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TradeCupcakeTowers_Buying : TradeCupcakeTowers {

    /* Public variable to identify which tower this script is selling.
     * Ideally, you could have many instances of this script selling different
     * Cupcake towers, and the tower is specified in the Inspector */
    public GameObject cupcakeTowerPrefab;


    public override void OnPointerClick(PointerEventData eventData) {
        //Retrieve from the prefab which is its initial cost
        int price = cupcakeTowerPrefab.GetComponent<CupcakeTowerScript>().initialCost;

        // Check if the player can afford to buy the tower
        if (price <= sugarMeter.getSugarAmount()) {
            //Payment succeds, and the cost is removed from the player's sugar
            sugarMeter.ChangeSugar(-price);
            //A new Cupcake tower is created
            GameObject newTower = Instantiate(cupcakeTowerPrefab);
            //The new Cupcake tower is also assigned as the current selection
            currentActiveTower = newTower.GetComponent<CupcakeTowerScript>();
        }
    }
}
