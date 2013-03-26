using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    public class HealingItem : Item
    {
        /// <summary>
        /// 
        /// </summary>
        public HealingItem()
        {
            
            base.SetName(" ");
            base.SetHoldable(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        public void Heal(Pokemon target)
        {
            base.SetTarget(target);
        }
    }
}
