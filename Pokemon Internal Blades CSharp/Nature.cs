using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Nature
    {
        const double INCREASE_STAT = 1.1;
        const double NORMAL_STAT = 1.0;
        const double DECREASE_STAT = 0.9;
        const bool YES = true;
        const bool NO = false;
        const string EMPTY = " ";

        /// <summary>
        /// Default Constructor. Makes an undeclared Nature object be Hardy.
        /// </summary>
        public Nature()
        {
            m_name = "Hardy";
            m_attMod = NORMAL_STAT;
            m_spattMod = NORMAL_STAT;
            m_defMod = NORMAL_STAT;
            m_spdefMod = NORMAL_STAT;
            m_speedMod = NORMAL_STAT;
        }

        /// <summary>
        /// Constructor to make a new Nature.
        /// </summary>
        /// <param name="name">The name of the Nature</param>
        /// <param name="attMod">The double value to multiply a pokemon's base attack by.</param>
        /// <param name="spattMod">The double value to multiply a pokemon's base special attack by.</param>
        /// <param name="defMod">The double value to multiply a pokemon's base defense by.</param>
        /// <param name="spdefMod">The double value to multiply a pokemon's base special defense by.</param>
        /// <param name="spdMod">The double value to multiply a pokemon's base speed by.</param>
        public Nature(string name, double attMod, double spattMod, double defMod, double spdefMod, double spdMod)
        {
            m_name = name;
            m_attMod = attMod;			// Sets attack mod value
            m_spattMod = spattMod;		// Sets spatt mod value
            m_defMod = defMod;		// sets def mod value
            m_spdefMod = spdefMod;	// sets spdef mod value
            m_speedMod = spdMod;		// sets speed mod value
        }


		private string m_name;		// name of the nature
        //	private Nature[] list;
        private double m_attMod;		// attack modification
        private double m_spattMod;		// spatt modification value
        private double m_defMod;		// defense modification value
        private double m_spdefMod;		// spdefense modification value
        private double m_speedMod;		// speed modification value

        /// <summary>
        /// This does all the creating of natures... or it will.
        /// </summary>
        private void InitializeList()
        {

        }


		/// <summary>
		/// Returns the attack modification double
		/// </summary>
		/// <returns>m_attMod</returns>
        public double GetAttackMod()
        {
            return m_attMod;
        }

		/// <summary>
        /// Returns the special attack modification double
		/// </summary>
		/// <returns>m_spattMod</returns>
        public double GetSpAttackMod()
        {
            return m_spattMod;
        }

		/// <summary>
        /// Returns the defense modification double
		/// </summary>
		/// <returns>m_defMod</returns>
        public double GetDefenseMod()
        {
            return m_defMod;
        }

		/// <summary>
        /// Returns the special defense modification double
		/// </summary>
		/// <returns>m_spdefMod</returns>
        public double GetSpDefenseMod()
        {
            return m_spdefMod;
        }

		/// <summary>
        /// Returns the speed modification double
		/// </summary>
		/// <returns>m_speedMod</returns>
        public double GetSpeedMod()
        {
            return m_speedMod;
        }

        /// <summary>
        /// Returns the Nature
        /// </summary>
        /// <returns>Nature to return</returns>
        public Nature GetNature()
        {
            return this;
        }

    }
}
