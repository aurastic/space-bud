using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this enum stores the types of sellable objects that derive from this class. 
public enum ItemType
{
    Flower,
    Concentrates,
    Vaporizors,
    Default
}

public enum StrainType
{
    Indica,
    Sativa,
    Hybrid
}

public abstract class SellableObject : ScriptableObject
{
    //This script holds attributes of all sellable objects (information available to all sellable)

    public GameObject inventorySlotPrefab;
    public ItemType type;
    public string itemName;
    [TextArea(15, 20)]  //makes box bigger for description
    public string description;

    public int addEcoFootprint;
    public int deductEcoFootprint;

    public int addHappyPoints;

    public int productMass;

    public StrainType strain;
    



}
