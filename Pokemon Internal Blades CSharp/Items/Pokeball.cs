using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon_Internal_Blades_CSharp.Items
{
    /// <summary>
    /// Pokeball class: Subclass of Item class.
    /// </summary>
    public class Pokeball : Item
    {
        			
		private double m_ballModifier;	// Catch Rate from 0.5 to 16.0
        private bool m_isMasterBall;
        private bool m_captureWorked;   // True if capture worked. Only used during Catch() method.


        /// <summary>
        /// Pokeball Default Constructor: Creates a normal Pokeball.
        /// </summary>
        public Pokeball()
        {
            base.SetName("Pokeball");
            base.SetHoldable(false);
            base.SetValue(300);
            m_isMasterBall = false;
            m_ballModifier = 1.0;
            m_captureWorked = false;
        }

        /// <summary>
        /// Constructor for a Pokeball object
        /// </summary>
        /// <param name="name">Name of the Pokeball</param>
        /// <param name="value">Value of the Pokeball</param>
        /// <param name="modifier">The modifier double used during capture.</param>
        public Pokeball(string name, long value, double modifier)
        {
            base.SetName(name);
            base.SetHoldable(false);
            base.SetValue(Math.Abs(value));
            if (modifier > 100)
                m_isMasterBall = true;
            else
                m_isMasterBall = false;
            m_ballModifier = modifier;
            m_captureWorked = false;
        }

        /// <summary>
        /// Method to catch the Pokemon target
        /// </summary>
        /// <param name="target">The Pokemon to attempt to catch.</param>
        public void Catch(Player player, Pokemon target)
        {
            // The Formulas are now implemented, but I have no idea if they are correct. 

            
            // CatchValue = ((( 3 * Max HP - 2 * HP ) * (Catch Rate * Ball Modifier ) / (3 * Max HP) ) * Status Modifier
            // Catch = 1048560 / √(√(16711680 / CatchValue)) = (2^20 - 2^4) / √(√((2^24 - 2^16) / CatchValue))

            base.SetTarget(target);
            
            double catchValue = ((( 3 * target.GetMaxHP() - 2 * target.GetCurrentHP()) * 
                (target.GetCatchRate() * m_ballModifier)) / 
                (3 * target.GetMaxHP())) * target.GetStatusModifier();

            if (catchValue >= 250 || m_isMasterBall)
            {
                m_captureWorked = true;
            }
            else
            {
                double catch1 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                double randomNumber = (double)target.GetRandom(0, 275);
                if (randomNumber >= catch1)
                {
                    m_captureWorked = true;
                }
                else
                {
                    double catch2 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                    randomNumber = (double)target.GetRandom((int)(randomNumber / 4), 275);
                    if (randomNumber >= catch2)
                    {
                        m_captureWorked = true;
                    }
                    else
                    {
                        double catch3 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                        randomNumber = (double)target.GetRandom((int)(randomNumber / 2), 275);
                        if (randomNumber >= catch3)
                        {
                            m_captureWorked = true;

                        }
                        else
                        {
                            m_captureWorked = false;
                        }
                    }
                }

            }
            if (m_captureWorked)
            {
                player.AddPokemon(target);
            }

        }

    }
}
