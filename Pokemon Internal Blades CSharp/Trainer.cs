using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp
{
    /// <summary>
    /// Trainer class
    /// </summary>
    public class Trainer
    {

        const int MALE = 0;
        const int FEMALE = 1;

        /// <summary>
        /// Default Trainer ID Definition
        /// </summary>
        const long DEFAULT_ID = 100000;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default Constructor. Sets m_cash to 3000 and m_gender to MALE. Has 1 default Pokemon.
        /// </summary>
        public Trainer()
        {
            m_party = new Pokemon[6];
            m_cash = 3000;
            m_gender = MALE;
            m_trainerID = DEFAULT_ID;
            m_party[0] = new Pokemon();
        }

        /// <summary>
        /// Creates a trainer with no pokemon.
        /// </summary>
        /// <param name="name">Name of the Trainer</param>
        /// <param name="cash">Cash the Trainer carries with him/her</param>
        /// <param name="gender">Gender of the Trainer. A 0 or a 1 value.</param>
        /// <param name="trainerID">A 6 digit trainer ID.</param>
        /// <param name="starter">The Trainer's first pokemon.</param>
        public Trainer(string name, long cash, int gender, long trainerID, Pokemon starter)
        {
            m_party = new Pokemon[6];
            m_name = name;
            m_cash = cash;
            if (gender != MALE || gender != FEMALE)
                m_gender = MALE;
            else
                m_gender = gender;

            if (trainerID < 100000 || trainerID >= 1000000)
                m_trainerID = DEFAULT_ID;
            else
                m_trainerID = trainerID;

            m_party[0] = starter;
        }


		private string m_name;			// Name of the trainer
        private int m_gender;			// Gender of the trainer
        private long m_cash;			// Cash amount of the trainer
        private Pokemon[] m_party;	// Pokemon in Party
        private long m_trainerID;		// ID of the trainer. Should be 6 characters.
		

        /// <summary>
        ///  Returns the Pokemon in index 0 of the array m_party
        /// </summary>
        /// <returns>First Pokemon</returns>
		public Pokemon GetLeadPokemon()
        {
            return m_party[0];
        }

        /// <summary>
        /// Returns the Pokemon in index 1 of the array m_party
        /// </summary>
        /// <returns>Second Pokemon</returns>
        public Pokemon GetSecondPokemon() 
        {
            return m_party[1]; 
        }

        /// <summary>
        /// Returns the Pokemon in index 2 of the array m_party
        /// </summary>
        /// <returns>Third Pokemon</returns>
        public Pokemon GetThirdPokemon() 
        { 
            return m_party[2]; 
        }

        /// <summary>
        /// Returns the Pokemon in index 3 of the array m_party
        /// </summary>
        /// <returns>Fourth Pokemon</returns>
        public Pokemon GetFourthPokemon() 
        { 
            return m_party[3];
        }

        /// <summary>
        /// Returns the Pokemon in index 4 of the array m_party
        /// </summary>
        /// <returns>Fifth Pokemon</returns>
        public Pokemon GetFifthPokemon() 
        { 
            return m_party[4]; 
        }

        /// <summary>
        /// Returns the Pokemon in index 5 of the array m_party
        /// </summary>
        /// <returns>Sixth Pokemon</returns>
        public Pokemon GetSixthPokemon() 
        { 
            return m_party[5]; 
        }

        /// <summary>
        /// Returns the amount of cash the trainer has.
        /// </summary>
        /// <returns>long m_cash</returns>
        public long GetCash()
        {
            return m_cash;
        }

        /// <summary>
        /// Returns the trainer's ID number
        /// </summary>
        /// <returns>long m_trainerID: 6 digit Trainer Identifier</returns>
        public long GetTrainerID()
        {
            return m_trainerID;
        }



    }
}
