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

using UnityEngine;

namespace SpaceBudPlayerData
{
    public enum AppearanceType
    {
        HairColor = 0,
        SkinColor = 1,
        Hats = 2
    }

    [CreateAssetMenu]

    public class AppearanceProfile : ScriptableObject
    {
        public Sprite listImage;
        public GameObject mesh;
        public Material material;
        public string textureID;
        public Texture texture;
        public AppearanceType type;
        public string appearanceName; //hat
        public string specifier; //sombrero
        public int cost;


    }
}
