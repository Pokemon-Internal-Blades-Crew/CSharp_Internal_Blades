using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    /// <summary>
    /// 
    /// </summary>
    public class EvolutionItem : Item
    {
        /// <summary>
        /// 
        /// </summary>
        public EvolutionItem()
        {
            base.SetName(" ");
            base.SetHoldable(true);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        public void EvolveTarget(Pokemon target)
        {
            base.SetTarget(target);
        }
    }
}
