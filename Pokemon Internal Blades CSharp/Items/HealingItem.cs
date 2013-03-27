using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    public class HealingItem : Item
    {
        private int m_degreeOfHealing;
        private bool m_isReviveItem;

        /// <summary>
        /// Healing Item Class Default Constructor
        /// </summary>
        public HealingItem()
        {
            
            base.SetName(" ");
            base.SetHoldable(true);
            m_degreeOfHealing = 25;
            m_isReviveItem = false;

        }

        // TODO: Create Healing Item Constructor that takes Parameters.

        /// <summary>
        /// Heals the Target Pokemon.
        /// </summary>
        /// <param name="target">Sets the target of the Healing.</param>
        public void Heal(Pokemon target)
        {
            base.SetTarget(target);
        }
    }
}
