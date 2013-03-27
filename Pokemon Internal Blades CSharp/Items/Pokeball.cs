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
            base.SetTarget(target);
            
            double catchValue = (( 3 * target.GetMaxHP() - 2 * target.GetCurrentHP()) * 
                (target.GetCatchRate() * m_ballModifier) / 
                (3 * target.GetMaxHP())) * target.GetStatusModifier();

            if (catchValue >= 250 || m_isMasterBall)
            {
                m_captureWorked = true;
            }
            else
            {
                double catch1 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / catchValue)));
                double randomNumber = (double)Pokemon.GetRandom(0, 65536);

                if (randomNumber <= catch1)
                {
                    m_captureWorked = true;
                }
                else
                {
                    randomNumber = (double)Pokemon.GetRandom(0, 65536);

                    if (randomNumber <= catch1)
                    {
                        m_captureWorked = true;
                    }
                    else
                    {
                        randomNumber = (double)Pokemon.GetRandom(0, 65536);

                        if (randomNumber <= catch1)
                        {
                            m_captureWorked = true;
                        }
                        else
                        {
                            m_captureWorked = false;
                            m_test4 = "Capture Failed...\n\n\n";
                        }
                    }
                }

            }
            if (m_captureWorked)
            {
                m_test4 = "Capture Successful!\n\n\n";
                if (player.AddPokemonToParty() == 0)
                {
                    player.AddPokemonToBox(target);
                }
                else
                {
                    player.AddPokemonToParty(target);
                }
            }

        }

        public double TestCaptureValue(Pokemon target, double statusMod)
        {
            double catchValue = ((double)(3 * target.GetMaxHP() - 2 * target.GetCurrentHP()) *
                (target.GetCatchRate() * m_ballModifier) /
                (3 * target.GetMaxHP())) * statusMod;

            return catchValue;
        }

        public double TestCaptureFormula2(Pokemon target, double statusMod)
        {
            double catch1 = (1048560 / Math.Sqrt(Math.Sqrt(16711680 / TestCaptureValue(target, statusMod))));
            return catch1;
        }

        public void SetBallMod(double ballMod)
        {
            m_ballModifier = ballMod;
        }

    }
}
