using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Move
    {

        const int NONE = 0;
        /// <summary>
        /// Normal Type
        /// Supereffective Against:			N/A
        /// Half Damage Dealt:				Fighting
        /// No Damage to:					Ghost
        /// No Damage from:					Ghost
        /// </summary>
        const int NORMAL = 1;
        /// <summary>
        /// Fighting Type
        /// Supereffective Against:			Normal, Ice, Rock, Dark, Steel
        /// Half Damage Dealt:				Poison, Flying, Psychic, Bug
        /// No Damage to:					Ghost
        /// No Damage from:					N/A
        /// </summary>
        const int FIGHTING = 2;
        /// <summary>
        /// Fire Type
        /// Supereffective Against:			Grass, Ice, Steel, Bug		
        /// Half Damage Dealt:				Fire, Water, Rock, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int FIRE = 3;
        /// <summary>
        /// Water Type
        /// Supereffective Against:			Fire, Ground, Rock	
        /// Half Damage Dealt:				Water, Grass, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int WATER = 4;
        /// <summary>
        /// Ice Type
        /// Supereffective Against:			Grass, Flying, Ground, Dragon	
        /// Half Damage Dealt:				Fire, Water, Ice, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ICE = 5;
        /// <summary>
        /// Grass Type
        /// Supereffective Against:			Water, Ground, Rock		
        /// Half Damage Dealt:				Fire, Grass, Poison, Flying, Bug, Dragon, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int GRASS = 6;
        /// <summary>
        /// Bug Type
        /// Supereffective Against:			Psychic, Dark, Grass		
        /// Half Damage Dealt:				Fire, Fighting, Poison, Fighting, Ghost, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int BUG = 7;
        /// <summary>
        /// Poison Type
        /// Supereffective Against:			Grass		
        /// Half Damage Dealt:				Poison, Ground, Rock, Ghost
        /// No Damage to:					Steel
        /// No Damage from:					N/A
        /// </summary>
        const int POISON = 8;
        /// <summary>
        /// Flying Type
        /// Supereffective Against:			Bug, Grass, Fighting		
        /// Half Damage Dealt:				Electric, Rock, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Ground
        /// </summary>
        const int FLYING = 9;
        /// <summary>
        /// Psychic Type
        /// Supereffective Against:			Fighting, Poison		
        /// Half Damage Dealt:				Psychic, Steel
        /// No Damage to:					Dark
        /// No Damage from:					N/A
        /// </summary>
        const int PSYCHIC = 10;
        /// <summary>
        /// Ghost Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Dark, Steel
        /// No Damage to:					Normal
        /// No Damage from:					Normal, Fighting
        /// </summary>
        const int GHOST = 11;
        /// <summary>
        /// Dark Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Fighting, Dark, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Psychic
        /// </summary>
        const int DARK = 12;
        /// <summary>
        /// Ground Type
        /// Supereffective Against:			Fire, Electric, Poison, Rock, Steel		
        /// Half Damage Dealt:				Water, Grass, Ice
        /// No Damage to:					Flying
        /// No Damage from:					Electric
        /// </summary>
        const int GROUND = 13;
        /// <summary>
        /// Steel Type
        /// Supereffective Against:			Ice, Bug		
        /// Half Damage Dealt:				Fire, Ice, Ground
        /// No Damage to:					N/A
        /// No Damage from:					Poison
        /// </summary>
        const int STEEL = 14;
        /// <summary>
        /// Rock Type
        /// Supereffective Against:			Fire, Ice, Flying, Bug		
        /// Half Damage Dealt:				Fighting, Ground, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ROCK = 15;
        /// <summary>
        /// Electric Type
        /// Supereffective Against:			Water, Flying		
        /// Half Damage Dealt:				Electric, Grass, Dragon
        /// No Damage to:					Ground
        /// No Damage from:					N/A
        /// </summary>
        const int ELECTRIC = 16;
        /// <summary>
        /// Dragon Type
        /// Supereffective Against:			Dragon		
        /// Half Damage Dealt:				Dragon, Ice
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int DRAGON = 17;
        /// <summary>
        /// Shadow Type
        /// Supereffective Against:			All but Shadow		
        /// Half Damage Dealt:				Shadow
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int SHADOW = 18;
        /// <summary>
        /// ??? Type
        /// Supereffective Against:			N/A
        /// Double Damage taken:			N/A
        /// Half Damage Dealt:				N/A
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int UNKNOWN = 19;

        const int LOW_MP = 5;
        const int LOW_MED_MP = 10;
        const int MEDIUM_MP = 15;
        const int MED_HIGH_MP = 20;
        const int HIGH_MP = 30;

        const bool YES = true;
        const bool NO = false;
        const string EMPTY = " ";

        /// <summary>
        /// Poisoned Effects: The Pokémon loses 1/8th Max HP each turn;
        ///	 For every 4 steps the trainer takes, the Pokémon loses 1 HP until it reaches 1 HP remaining
        /// </summary>
        const int POISONED = 1;
        /// <summary>
        /// Paralysis Effects: The Pokémon afflicted's Speed stat is reduced to 25% of it's Maximum. 
        ///  Pokémon with the Quick Feet ability are not affected by the Speed reduction
        ///  The Pokémon has a 25% chance of being unable to attack each turn
        /// </summary>
        const int PARALYZED = 2;
        /// <summary>
        /// Burned Effects: Each turn, the Pokémon afflicted with the Burn loses 1/8th of it's Max HP
        ///  The Pokémon's Physical Attack Stat is cut by Half. This effect does not work on Pokémon with the Guts ability
        ///  The Pokémon's Special Attack Stat is doubled on Pokémon with the Heat Rampage ability
        /// </summary>
        const int BURNED = 3;
        /// <summary>
        /// Frozen Effects: The Pokémon cannot use any attacks (apart from those that thaw it)
        /// </summary>
        const int FROZEN = 4;
        /// <summary>
        /// Sleeping Effects: The Pokémon cannot attack for 1 to 7 turns, the turn count is lowered with the Early Bird ability
        ///  Sleep Talk & Snore can be used
        ///  Allows the attacks Dream Eater & Nightmare as well as the ability Bad Dreams to be used against you
        /// </summary>
        const int SLEEPING = 5;
        /// <summary>
        /// Attracted Effects: The Pokémon afflicted cannot attack 50% of the time
        /// </summary>
        const int ATTRACTED = 6;
        /// <summary>
        /// Confusion Effects: The Pokémon afflicted cannot attack 50% of the time for 1-4 turns
        ///  Raises Evasion for Pokémon with the Tangled Feed ability
        /// </summary>
        const int CONFUSED = 7;
        /// <summary>
        /// Cursed Effects: The Pokémon afflicted loses 1/4 of it's Max HP each turn
        /// </summary>
        const int CURSED = 8;
        /// <summary>
        /// Badly Poisoned Effects: The Pokémon loses 1/16th Max HP for the first turn and then adds 1/16th to the amount to be lost 
        ///  so on 2nd turn 2/16th, 3rd 3/16th and so on until the Pokémon faints
        /// </summary>
        const int BAD_POISON = 9;

        const int MALE = 0;
        const int FEMALE = 1;

        /// <summary>
        /// Default Constructor. Makes the move initially set to Tackle
        /// </summary>
        public Move()
        {
            m_name = "Tackle";		// Sets name to Tackle
            m_moveType = NORMAL;	// Normal Move: Default
            m_accuracy = 100;		// High accuracy
            m_speed = 0;			// Normal Speed Priority
            m_power = 35;			// Thirty-Five Power
            m_mp = HIGH_MP;			// 30 MP
        }

        /// <summary>
        /// Move Constructor.
        /// </summary>
        /// <param name="name">This is the name of the Move</param>
        /// <param name="acc">This is the accuracy of the Move from 1 to 100</param>
        /// <param name="speed">This is the speed priority of the move from -8 to 8 inclusive</param>
        /// <param name="power">This is the power of the move from 0 to 500</param>
        /// <param name="mp">This is the number of times the move can be used. Use const variables as parameters.</param>
        /// <param name="moveType"></param>
        public Move(string name, int acc, int speed, int power, int mp, int moveType)
        {
            m_name = name;
            m_accuracy = acc;
            m_speed = speed;
            m_power = power;
            m_mp = mp;
            m_moveType = moveType;

        }
		
		private string		m_name;			// Name of the move
		private int			m_accuracy;		// Base accuracy from 1 to 100. If n/a, set to 1000
		private int			m_speed;		// Speed priority is -8 to 8 inclusive with 8 is fastest
		private int			m_power;		// Move_class's base power.
		private int			m_mp;			// How many times move can be used.
		private int			m_moveType;		// Type of the Move


		/// <summary>
		/// Sets the accuracy of the move
		/// </summary>
		/// <param name="acc">The accuracy of the move</param>
		private void SetAccuracy(int acc)
        {
            m_accuracy = acc;
        }	

		/// <summary>
		/// Sets the speed priority of the mvoe
		/// </summary>
		/// <param name="speed">The speed priority of the move</param>
		private void SetSpeed(int speed)
        {
            m_speed = speed;
        }		

		/// <summary>
		/// Sets the power of the move
		/// </summary>
		/// <param name="power">The power of the move</param>
		private void SetPower(int power)
        {
            m_power = power;
        }
		
		/// <summary>
		/// Sets the mp of the move
		/// </summary>
		/// <param name="mp">The number of times the move can be used.</param>
		private void SetMP(int mp)
        {
            m_mp = mp;
        }


		/// <summary>
		/// Returns the name of the move
		/// </summary>
		/// <returns>m_name</returns>
        public string GetName() 
        { 
            return m_name; 
        }

		/// <summary>
		/// Returns the accuracy of the move
		/// </summary>
		/// <returns>m_accuracy</returns>
        public int GetAccuracy()
        {
            return m_accuracy;
        }

		/// <summary>
		/// Returns the speed priority of the move
		/// </summary>
		/// <returns>m_speed</returns>
        public int GetPriority()
        {
            return m_speed;
        }

		/// <summary>
		/// Returns the power of the move
		/// </summary>
		/// <returns>m_power</returns>
        public int GetPower()
        { 
            return m_power;
        }

		/// <summary>
		/// Returns the Max MP of the move
		/// </summary>
		/// <returns>m_mp</returns>
        public int GetMP()
        {
            return m_mp;
        }		

		/// <summary>
		/// Sets all stats within one method
		/// </summary>
		/// <param name="acc">The new accuracy of the move.</param>
		/// <param name="speed">The new speed priority of the move.</param>
		/// <param name="power">The new power of the move.</param>
		/// <param name="mp">The new mp of the move.</param>
        public void SetMoveStats(int acc, int speed, int power, int mp)	
		{
			SetAccuracy(acc);	// Sets accuracy to acc
			SetSpeed(speed);	// Sets speed to speed
			SetPower(power);	// Sets power to power
			SetMP(mp);			// Sets mp to mp
		}


		/// <summary>
		/// Returns the move's type as an int. Compare to const table in Move.cs.
		/// </summary>
		/// <returns>m_moveType</returns>
        public int GetTyping()
        {
            return m_moveType;
        }

        /// <summary>
        /// Checks to see if the Move gets the Same Type Attack Bonus (STAB)
        /// </summary>
        /// <param name="target">The user of the move</param>
        /// <returns>Returns true if the attack gets STAB</returns>
		bool CheckSTAB(Pokemon target)
        {
	        bool isTrue;
	        if(GetTyping() == target.GetType1() || GetTyping() == target.GetType2())
		        isTrue = true;
	        else
		        isTrue = false;
	        return isTrue;
        }

		
    }
}
