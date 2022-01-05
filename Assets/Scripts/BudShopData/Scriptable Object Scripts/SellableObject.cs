//Copyright © 2022 Alex Reid (R.M.P.)

//This file is part of Space Bud.

//Space Bud is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License,
//or (at your option) any later version.

//Space Bud is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public
//License along with Space Bud. If not, see <https://www.gnu.org/licenses/>.

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
