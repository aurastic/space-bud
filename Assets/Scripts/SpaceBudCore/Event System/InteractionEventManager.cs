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

using System;
using UnityEngine;

namespace SpaceBudCore
{
    public static class InteractionEventManager
    {
        public delegate void CollisionAction(Transform t);
        public static event CollisionAction onCollidedWithInteraction;

        public delegate void UndoCollisionAction(Transform t);
        public static event UndoCollisionAction onUndoCollision;

        public delegate void SelectionChangeAction(Transform t);
        public static event SelectionChangeAction onSelectionChange;

        public static void CollidedWithInteraction(Transform transform)
        {
            onCollidedWithInteraction?.Invoke(transform);
        }

        public static void ColliderMovedAway(Transform transform)
        {
            onUndoCollision?.Invoke(transform);
        }
        public static void SelectionChanged(Transform t)
        {
            onSelectionChange?.Invoke(t);
        }


    }
}

