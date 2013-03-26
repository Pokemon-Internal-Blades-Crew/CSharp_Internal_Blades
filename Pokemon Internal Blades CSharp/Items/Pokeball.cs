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
    public class Pokeball : Item
    {
        			
		private double m_captureRate;	// Catch Rate from 0.5 to 16.0

		// CatchValue = ((( 3 * Max HP - 2 * HP ) * (Catch Rate * Ball Modifier ) / (3 * Max HP) ) * Status Modifier
		// Catch = 1048560 / √(√(16711680 / CatchValue)) = (220 - 24) / √(√((224 - 216) / CatchValue))

        /// <summary>
        /// 
        /// </summary>
        public Pokeball()
        {
            base.SetName(" ");
            base.SetHoldable(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        public void Catch(Pokemon target)
        {
            base.SetTarget(target);
        }

    }
}
