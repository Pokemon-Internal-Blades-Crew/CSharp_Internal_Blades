using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Pokemon_Internal_Blades_CSharp
{
    /// <summary>
    /// Pokeball class: Subclass of Item class.
    /// </summary>
    public class Pokeball : Item
    {
        			
		private double m_ballModifier;	// Catch Rate from 0.5 to 16.0
        private bool m_isMasterBall;
        private bool m_captureWorked;   // True if capture worked. Only used during Catch() method.

        private double m_catchValue;
        private double m_catch1;
        private double m_catch2;
        private double m_catch3;
        private double m_randomNumber1;
        private double m_randomNumber2;
        private double m_randomNumber3;

        public string m_test1 = "";
        public string m_test2 = "";
        public string m_test3 = "";
        public string m_test4 = "";


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
            m_catchValue = catchValue;
            if (catchValue >= 250 || m_isMasterBall)
            {
                m_captureWorked = true;
                m_test4 = "m_catchValue: " + m_catchValue + "\nCapture Success!\n\n------------------\n";
            }
            else
            {
                double catch1 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                double randomNumber = (double)Pokemon.GetRandom(0, 65536);
                m_catch1 = catch1;
                m_randomNumber1 = randomNumber;
                if (randomNumber >= catch1)
                {
                    m_captureWorked = true;
                    m_test1 = "m_catchValue: " + m_catchValue + "\nm_catch1: " + m_catch1 + "\nm_randomNumber1: " + m_randomNumber1 + "\n" + "Catch1: Success!\n\n";
                }
                else
                {
                    m_test1 = /*"m_catchValue: " + m_catchValue + "\n" "m_catch1: " + m_catch1 + "\nm_randomNumber1: " + m_randomNumber1 + */  "\nCatch1: Fail\n";
                    double catch2 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                    randomNumber = (double)Pokemon.GetRandom(0, 65536);
                    m_catch2 = catch2;
                    m_randomNumber2 = randomNumber;

                    if (randomNumber >= catch2)
                    {
                        m_captureWorked = true;
                        m_test2 = "m_catch2: " + m_catch2 + "\nm_randomNumber2: " + m_randomNumber2 + "\nCatch2: Success!\n\n";
                    }
                    else
                    {
                        m_test2 = /*"m_catch2: " + m_catch2 + "\n"m_randomNumber2: " + m_randomNumber2 + "\n\n" + "*/  "Catch2: Fail\n";
                        double catch3 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                        randomNumber = (double)Pokemon.GetRandom(0, 65536);
                        m_catch3 = catch3;
                        m_randomNumber3 = randomNumber;
                        if (randomNumber >= catch3)
                        {
                            m_captureWorked = true;
                            m_test3 = "m_catch3: " + m_catch3 + "\nm_randomNumber3: " + m_randomNumber3 + "\nCatch3: Success!\n\n";
                        }
                        else
                        {
                            m_captureWorked = false;
                            m_test3 = /*"m_catch3: " + m_catch3 + "\nm_randomNumber3: " + m_randomNumber3 +*/ "Catch3: Fail\n";
                            m_test4 = "Capture Failed\n\n------------------\n";
                        }
                    }
                }

            }
            if (m_captureWorked)
            {
                m_test4 = "m_catchValue: " + m_catchValue + "\nCapture Success!\n\n------------------\n";
              /*  if (player.AddPokemonToParty(target) == 0)
                {
                    player.AddPokemonToBox(target);
                }*/
            }

        }

        

    }
}
