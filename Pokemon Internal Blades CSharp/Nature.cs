using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// 
        /// </summary>
        public Nature()
        {
            m_name = EMPTY;
            m_attMod = NORMAL_STAT;
            m_spattMod = NORMAL_STAT;
            m_defMod = NORMAL_STAT;
            m_spdefMod = NORMAL_STAT;
            m_speedMod = NORMAL_STAT;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="atMod"></param>
        /// <param name="spatMod"></param>
        /// <param name="defMod"></param>
        /// <param name="spdefMod"></param>
        /// <param name="spdMod"></param>
        public Nature(string name, double atMod, double spatMod, double defMod, double spdefMod, double spdMod)
        {
            m_name = name;
            m_attMod = atMod;			// Sets attack mod value
            m_spattMod = spatMod;		// Sets spatt mod value
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
        /// 
        /// </summary>
        private void InitializeList()
        {

        }


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public double GetAttackMod()
        {
            return m_attMod;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public double GetSpAttackMod()
        {
            return m_spattMod;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public double GetDefenseMod()
        {
            return m_defMod;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public double GetSpDefenseMod()
        {
            return m_spdefMod;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public double GetSpeedMod()
        {
            return m_speedMod;
        }

    }
}
