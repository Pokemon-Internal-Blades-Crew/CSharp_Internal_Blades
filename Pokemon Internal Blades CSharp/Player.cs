using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Player : Trainer
    {

        const int MALE = 0;
        const int FEMALE = 1;

        /// <summary>
        /// Default Trainer ID Definition
        /// </summary>
        const long DEFAULT_ID = 100000;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Player Constructor: Upon Construction, the Player is given 3000 cash default, a starter pokemon, a random 
        /// 6 digit trainer ID, and a random 6 digit secret ID
        /// </summary>
        /// <param name="name">Name of the Player</param>
        /// <param name="gender">Gender of the Player. A 0 or a 1 value.</param>
        /// <param name="starter">The Player's first pokemon.</param>
        Player(string name, int gender, Pokemon starter)
        {
            m_party = new Pokemon[6];
            m_name = name;
            m_cash = 3000;
            if (gender != MALE || gender != FEMALE)
                m_gender = MALE;
            else
                m_gender = gender;
            m_trainerID = rnd.Next(100000, 1000000);
            m_secretID = rnd.Next(100000, 1000000);
            m_party[0] = starter;
        }

        private Random rnd = new Random();
        private string m_name;			// Name of the trainer
        private int m_gender;			// Gender of the trainer
        private long m_cash;			// Cash amount of the trainer
        private Pokemon[] m_party;	// Pokemon in Party
        private long m_trainerID;		// ID of the trainer. Should be 6 characters.
        private long m_secretID;
        private BoxSystem m_boxSystem = new BoxSystem();
        private static int m_boxIndex = 0;
        private static int m_partyCount = 0;

        /// <summary>
        /// Returns the Player's ID
        /// </summary>
        /// <returns>long m_trainerID: unique 6 digit trainer ID</returns>
        public long GetPlayerID()
        {
            return m_trainerID;
        }

        /// <summary>
        /// Returns the Player's Secret ID
        /// </summary>
        /// <returns>long m_secretID: unique 6 digit secret ID</returns>
        public long GetSecretID()
        {
            return m_secretID;
        }

        /// <summary>
        /// Returns the Amount of money the Player has
        /// </summary>
        /// <returns>long m_cash: Total Money the Player has</returns>
        public long GetMoney()
        {
            return m_cash;
        }

        /// <summary>
        /// Adds money to the player's cache of cash
        /// </summary>
        /// <param name="cash">Positive Amount of cash to be added to the player's cache of cash.</param>
        public void AddMoney(long cash)
        {
            if(cash != 0)
                m_cash += Math.Abs(cash);
        }

        /// <summary>
        /// Subtracts money from the player's cache of cash. Even though it subtracts, cash must be positive!
        /// </summary>
        /// <param name="cash">Amount of cash to be deducted from the player's cache of cash</param>
        public void LoseMoney(long cash)
        {
            if (cash != 0)
                m_cash -= Math.Abs(cash);
        }

        /// <summary>
        /// Adds the Pokemon to the box system.
        /// </summary>
        /// <param name="target">The Pokemon to add to the Box System</param>
        public void AddPokemon(Pokemon target)
        {
            m_boxSystem.AddPokemonToBoxSystem(target);
            target.SetOwned(true);
        }


    }
}
