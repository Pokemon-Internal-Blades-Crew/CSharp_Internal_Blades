using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace Pokemon_Internal_Blades_CSharp
{
    /// <summary>
    /// Pokemon Class
    /// <remarks>
    /// A Pokemon has two types
    /// A Pokemon has a Move pool
    /// A Pokemon can have up to four abilities
    /// A Pokemon has a gender
    /// A Pokemon has stats
    /// </remarks>
    /// 
    /// </summary>
    public class Pokemon
	{
      
        /// <summary>
        /// NONE should be used only when the program is asking for a second type and the pokemon does not technically have one.
        /// </summary>
        const int NONE		=	0;
        /// <summary>
        /// Normal Type
        /// Supereffective Against:			N/A
        /// Half Damage Dealt:				Fighting
        /// No Damage to:					Ghost
        /// No Damage from:					Ghost
        /// </summary>
        const int NORMAL	=	1;
        /// <summary>
        /// Fighting Type
        /// Supereffective Against:			Normal, Ice, Rock, Dark, Steel
        /// Half Damage Dealt:				Poison, Flying, Psychic, Bug
        /// No Damage to:					Ghost
        /// No Damage from:					N/A
        /// </summary>
        const int FIGHTING	=	2;
        /// <summary>
        /// Fire Type
        /// Supereffective Against:			Grass, Ice, Steel, Bug		
        /// Half Damage Dealt:				Fire, Water, Rock, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int FIRE		=	3;
        /// <summary>
        /// Water Type
        /// Supereffective Against:			Fire, Ground, Rock	
        /// Half Damage Dealt:				Water, Grass, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int WATER		=	4;
        /// <summary>
        /// Ice Type
        /// Supereffective Against:			Grass, Flying, Ground, Dragon	
        /// Half Damage Dealt:				Fire, Water, Ice, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ICE		=	5;
        /// <summary>
        /// Grass Type
        /// Supereffective Against:			Water, Ground, Rock		
        /// Half Damage Dealt:				Fire, Grass, Poison, Flying, Bug, Dragon, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int GRASS		=	6;
        /// <summary>
        /// Bug Type
        /// Supereffective Against:			Psychic, Dark, Grass		
        /// Half Damage Dealt:				Fire, Fighting, Poison, Fighting, Ghost, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int BUG		=	7;
        /// <summary>
        /// Poison Type
        /// Supereffective Against:			Grass		
        /// Half Damage Dealt:				Poison, Ground, Rock, Ghost
        /// No Damage to:					Steel
        /// No Damage from:					N/A
        /// </summary>
        const int POISON	=   8;
        /// <summary>
        /// Flying Type
        /// Supereffective Against:			Bug, Grass, Fighting		
        /// Half Damage Dealt:				Electric, Rock, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Ground
        /// </summary>
        const int FLYING	=	9;
        /// <summary>
        /// Psychic Type
        /// Supereffective Against:			Fighting, Poison		
        /// Half Damage Dealt:				Psychic, Steel
        /// No Damage to:					Dark
        /// No Damage from:					N/A
        /// </summary>
        const int PSYCHIC	=	10;
        /// <summary>
        /// Ghost Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Dark, Steel
        /// No Damage to:					Normal
        /// No Damage from:					Normal, Fighting
        /// </summary>
        const int GHOST		=	11;
        /// <summary>
        /// Dark Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Fighting, Dark, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Psychic
        /// </summary>
        const int DARK		=	12;
        /// <summary>
        /// Ground Type
        /// Supereffective Against:			Fire, Electric, Poison, Rock, Steel		
        /// Half Damage Dealt:				Water, Grass, Ice
        /// No Damage to:					Flying
        /// No Damage from:					Electric
        /// </summary>
        const int GROUND	=	13;
        /// <summary>
        /// Steel Type
        /// Supereffective Against:			Ice, Bug		
        /// Half Damage Dealt:				Fire, Ice, Ground
        /// No Damage to:					N/A
        /// No Damage from:					Poison
        /// </summary>
        const int STEEL		=	14;
        /// <summary>
        /// Rock Type
        /// Supereffective Against:			Fire, Ice, Flying, Bug		
        /// Half Damage Dealt:				Fighting, Ground, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ROCK		=	15;
        /// <summary>
        /// Electric Type
        /// Supereffective Against:			Water, Flying		
        /// Half Damage Dealt:				Electric, Grass, Dragon
        /// No Damage to:					Ground
        /// No Damage from:					N/A
        /// </summary>
        const int ELECTRIC	=	16;
        /// <summary>
        /// Dragon Type
        /// Supereffective Against:			Dragon		
        /// Half Damage Dealt:				Dragon, Ice
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int DRAGON	=	17;
        /// <summary>
        /// Shadow Type
        /// Supereffective Against:			All but Shadow		
        /// Half Damage Dealt:				Shadow
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int SHADOW	=	18;
        /// <summary>
        /// ??? Type
        /// Supereffective Against:			N/A
        /// Double Damage taken:			N/A
        /// Half Damage Dealt:				N/A
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int UNKNOWN	=	19;
        
        const int LOW_MP		=	5;
        const int LOW_MED_MP	=	10;
        const int MEDIUM_MP	=	15;
        const int MED_HIGH_MP =	20;
        const int HIGH_MP	=	30;

        const double INCREASE_STAT =	1.1;
        const double NORMAL_STAT	  =	1.0;
        const double DECREASE_STAT =	0.9;

        const bool YES			=	true;
        const bool NO			=	false;

        const string EMPTY			=   " ";

        /// <summary>
        /// Status: None
        /// </summary>
        const int NO_STATUS     =   0;
        /// <summary>
        /// Poisoned Effects: The Pokémon loses 1/8th Max HP each turn;
        ///	 For every 4 steps the trainer takes, the Pokémon loses 1 HP until it reaches 1 HP remaining
        /// </summary>
        const int POISONED		=   1;
        /// <summary>
        /// Paralysis Effects: The Pokémon afflicted's Speed stat is reduced to 25% of it's Maximum. 
        ///  Pokémon with the Quick Feet ability are not affected by the Speed reduction
        ///  The Pokémon has a 25% chance of being unable to attack each turn
        /// </summary>
        const int PARALYZED		=   2;
        /// <summary>
        /// Burned Effects: Each turn, the Pokémon afflicted with the Burn loses 1/8th of it's Max HP
        ///  The Pokémon's Physical Attack Stat is cut by Half. This effect does not work on Pokémon with the Guts ability
        ///  The Pokémon's Special Attack Stat is doubled on Pokémon with the Heat Rampage ability
        /// </summary>
        const int BURNED		=   3;
        /// <summary>
        /// Frozen Effects: The Pokémon cannot use any attacks (apart from those that thaw it)
        /// </summary>
        const int FROZEN		=   4;
        /// <summary>
        /// Sleeping Effects: The Pokémon cannot attack for 1 to 7 turns, the turn count is lowered with the Early Bird ability
        ///  Sleep Talk & Snore can be used
        ///  Allows the attacks Dream Eater & Nightmare as well as the ability Bad Dreams to be used against you
        /// </summary>
        const int SLEEPING		=   5;
        /// <summary>
        /// Attracted Effects: The Pokémon afflicted cannot attack 50% of the time
        /// </summary>
        const int ATTRACTED		=   6;
        /// <summary>
        /// Confusion Effects: The Pokémon afflicted cannot attack 50% of the time for 1-4 turns
        ///  Raises Evasion for Pokémon with the Tangled Feed ability
        /// </summary>
        const int CONFUSED   	=	7;
        /// <summary>
        /// Cursed Effects: The Pokémon afflicted loses 1/4 of it's Max HP each turn
        /// </summary>
        const int CURSED		=   8;
        /// <summary>
        /// Badly Poisoned Effects: The Pokémon loses 1/16th Max HP for the first turn and then adds 1/16th to the amount to be lost 
        ///  so on 2nd turn 2/16th, 3rd 3/16th and so on until the Pokémon faints
        /// </summary>
        const int BAD_POISON	=   9;

        const int MALE			=   0;
        const int FEMALE		=   1;

        /// <summary>
        /// Default Trainer ID Definition
        /// </summary>
        const long DEFAULT_ID	=	100000;

        // Methods of Evolution
        const int NO_EVOLUTION        =   00;
        const int LVL                 =   01;
        const int LVL_DAY_HAPPY       =   02;
        const int LVL_NIGHT_HAPPY     =   03;
        const int LVL_AREA            =   04;
        const int LVL_MOVE_ROLLOUT    =   05;
        const int LVL_MOVE_ANCIENT    =   06;
        const int LVL_OVAL_STONE      =   07;
        const int LVL_RAZOR_FANG      =   08;
        const int LVL_RAZOR_CLAW      =   09;
        const int TRADE_DEEP_SCALE    =   10;
        const int TRADE_DEEP_TOOTH    =   11;
        const int TRADE_DRAGON_SCALE  =   12;
        const int TRADE_DUBIOUS       =   13;
        const int TRADE_ELEC          =   14;
        const int TRADE_KINGS_ROCK    =   15;
        const int TRADE_MAGM          =   16;
        const int TRADE_METAL_COAT    =   17;
        const int TRADE_PRISM_SCALE   =   18;
        const int TRADE_PROTECTOR     =   19;
        const int TRADE_REAPER_CLOTH  =   20;
        const int TRADE_UPGRADE       =   21;
        const int LVL_EXTRA_SLOT      =   22;
        const int LVL_MALE            =   23;
        const int LVL_FEMALE          =   24;
        const int LVL_STATS           =   25;
        const int LVL_OTHER_PKMN      =   26;
        const int TRADE_NO_ITEM       =   27;
        const int I_FIRE_STONE        =   28;
        const int I_WATER_STONE       =   29;
        const int I_THUNDERSTONE      =   30;
        const int I_LEAF_STONE        =   31;
        const int I_MOON_STONE        =   32;
        const int I_SUN_STONE         =   33;
        const int I_DAWN_STONE        =   34;
        const int I_DUSK_STONE        =   35;
        const int I_SHINY_STONE       =   36;

        //-----------------------------------------------------------------------------------------------------


        public Pokemon(string name, string classification, int type1, int type2, bool owned, int level, int catchRate, int howEvolves,
            Pokemon evolution, Ability ability1, Ability ability2, Ability hidden1, Ability hidden2, Nature nature)
        {
            m_name = name;		// Sets the Pokemon's name to name
            m_nickname = name;
            m_classification = classification;	// Sets the pokemon's classification to classification.

            m_isFainted = NO;	// Automatic is not fainted
            m_owned = owned;	// Set owned status. True is trainer, false is wild.

            m_type1 = type1;	// Set first type.
            m_type2 = type2;	// Set second type. If in real game, this does not exist, type2 is NONE.

            m_level = level;    // Sets level
            m_happiness = 90;   // Sets happiness

            m_ability1 = ability1;
            m_ability2 = ability2;
            m_abilityHidden1 = hidden1;
            m_abilityHidden2 = hidden2;

            m_nature = nature;

            // Sets IVs and EVs
            SetIVs();
            SetEVs();

            // Sets default to no status
            m_status = NO_STATUS;

            // Sets the capture rate
            m_catchRate = catchRate;

            // This will eventually get changed when the constructor takes an int parameter.
            m_howEvolves = howEvolves;
            m_evolution = evolution;

            if (m_howEvolves > 0)
                m_canEvolve = true;
            else
                m_canEvolve = false;

        }


        /// <summary>
        /// Constructor for a new Pokemon.
        /// </summary>
        /// <param name="name">Name of the Pokemon.</param>
        /// <param name="classification">Classification of the Pokemon.</param>
        /// <param name="type1">The first type of the Pokemon in int form.</param>
        /// <param name="type2">The second type of the Pokemon in int form.</param>
        /// <param name="owned">Boolean value telling if the Pokemon is a trainer Pokemon or not.</param>
        /// <param name="level">The level of the Pokemon from 1 to 100 inclusive</param>
        public Pokemon(string name, string classification, int type1, int type2, bool owned, int level, int catchRate)
        {
            m_name = name;		// Sets the Pokemon's name to name
            m_nickname = name;
            m_classification = classification;	// Sets the pokemon's classification to classification.

            m_isFainted = NO;	// Automatic is not fainted
            m_owned = owned;	// Set owned status. True is trainer, false is wild.

            m_type1 = type1;	// Set first type.
            m_type2 = type2;	// Set second type. If in real game, this does not exist, type2 is NONE.

            m_level = level;    // Sets level
            m_happiness = 90;   // Sets happiness

            // These will eventually be overriden when Abilities get added to constructor
            m_ability1 = new Ability();
            m_ability2 = new Ability();
            m_abilityHidden1 = new Ability();
            m_abilityHidden2 = new Ability();

            // See above comment.
            m_nature = new Nature();


            // Sets IVs and EVs
            SetIVs();
            SetEVs();

            // Sets default to no status
            m_status = NO_STATUS;
            
            // Sets the capture rate
            m_catchRate = catchRate;

            // This will eventually get changed when the constructor takes an int parameter.
            m_howEvolves = NO_EVOLUTION;
            if (m_howEvolves > 0)
                m_canEvolve = true;
            else
                m_canEvolve = false;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Pokemon()
        {
            m_level = 5;
            m_name = EMPTY;
            
            m_type1 = NORMAL;
            m_type2 = NONE;
            m_isFainted = NO;
            m_owned = NO;
            
            SetIVs();
            SetEVs();

            m_status = NO_STATUS;

            m_ability1 = new Ability();
            m_ability2 = new Ability();
            m_abilityHidden1 = new Ability();
            m_abilityHidden2 = new Ability();

            m_nature = new Nature();
            
            m_catchRate = 255;
            m_happiness = 90;

            m_howEvolves = NO_EVOLUTION;
            
            if (m_howEvolves > 0)
                m_canEvolve = true;
            else
                m_canEvolve = false;
        }


        static Random random = new Random();
        

        private ArrayList	   m_moveCanKnowList;  // List of the Pokemon's overall Move Pool
        private ArrayList      m_moveKnowsList;    // List of the Pokemon's current Move Pool
        private ArrayList      m_eggMoves;         // List of the Pokemon's possible Egg Moves.

        private Move        m_moveUsing;        // Last move used.


		private string		m_name;				// Pokemon Name
		private string		m_nickname;			// Nickname given to Pokemon. Default should be m_name
		private string		m_classification;	// The Classification of the Pokemon. IE. Espeon: 'The Sun Pokemon'

		private Ability		m_ability1;			// First ability
		private Ability		m_ability2;			// Second ability
		private Ability		m_abilityHidden1;	// Third ability
		private Ability		m_abilityHidden2;	// Fourth ability
		
		private Nature		m_nature;			// Nature of the Pokemon

		 private int	m_level;			// from 1 to 100

		 private int	m_baseHealth;		// Base Hp
		 private int	m_baseAttack;		// Base attack
		 private int	m_baseSpAttack;		// Base Special Attack
		 private int	m_baseDefense;		// Base Defense
		 private int	m_baseSpDefense;	// Base Special Defense
		 private int	m_baseSpeed;		// Base Speed

		 private int	m_HP;				// Formula calculated HP stat
		 private int	m_Attack;			// Formula calculated Attack stat
		 private int	m_SpAttack;			// Formula calculated Special Attack stat
		 private int	m_Defense;			// Formula calculated Defense stat
		 private int	m_SpDefense;		// Formula calculated Special Defense stat
		 private int	m_Speed;			// Formula calculated Speed stat

		// IV codes
		 private int	m_hpIV;				// Health Individual Value from 1 to 31
		 private int	m_attIV;			// Attack Individual Value (IV) from 1 to 31
		 private int	m_spAttIV;			// Special Attack IV from 1 to 31
		 private int	m_defIV;			// Defense IV from 1 to 31
		 private int	m_spDefIV;			// Special Defense IV from 1 to 31
		 private int	m_speedIV;			// Speed IV from 1 to 31

		// EV codes
		 private int	m_hpEV;				// Health Effort Value from 0 to 255
		 private int	m_attEV;			// Attack Effort Values (EV) from 0 to 255
		 private int	m_spAttEV;			// Special Attack Effort Values (EV) from 0 to 255
		 private int	m_defEV;			// Defense Effort Values (EV) from 0 to 255
		 private int	m_spDefEV;			// Special Defense Effort Values (EV) from 0 to 255
		 private int	m_speedEV;			// Speed Effort Values (EV) from 0 to 255

		private int			m_currentHP;		// Used in battle. When reaches 0, pokemon faints.
		//private double		m_damage;			// Damage value
		//private double		m_stab;				// Same Type Attack Bonus
		//private double		m_effectiveness;	// Effectiveness against target.

		private bool		m_owned;			// Tells if owned. Default to wild: false
		private bool		m_isFainted;		// Tells if the Pokemon is fainted. Default is false.

		private int			m_type1;			// First type.  Default is NORMAL
		private int			m_type2;			// Second Type. Default is NONE

		private int	        m_happiness;		// Happiness Value from 0 to 255

        private bool        m_canEvolve;        // True if the Pokemon can evolve. False if not.

        private Pokemon     m_evolution;        // The Pokemon the pokemon evolves into, if it exists.

        private int         m_howEvolves;       // The way a pokemon Evolves. See above const declarations.

        private int         m_catchRate;        // 1 to 255

        private int         m_status;           // 0 is None

        /// <summary>
        /// Sets IVs
        /// </summary>
		private void SetIVs()
        { 
	        m_hpIV      = random.Next(0, 31) + 1;	// HP Individual Value from 1 to 31
	        m_attIV     = random.Next(0, 31) + 1;	// Attack Individual Values (IV) from 1 to 31
            m_spAttIV   = random.Next(0, 31) + 1;	// Special Attack IV from 1 to 31
            m_defIV     = random.Next(0, 31) + 1;	// Defense IV from 1 to 31
            m_spDefIV   = random.Next(0, 31) + 1;	// Special Defense IV from 1 to 31
            m_speedIV   = random.Next(0, 31) + 1;	// Speed IV from 1 to 31
        }

        /// <summary>
        /// Set the stats using a formula
        /// </summary>
		private void SetStats()
        {
            /*
                Attack, Defense, Speed, Sp. Attack, Sp. Defense:
                   (((IV + 2 * BaseStat + (EV/4) ) * Level/100 ) + 5) * Nature Value
            */

            m_HP = (int)(((m_hpIV + 2 * m_baseHealth + ((double)m_hpEV / 4)) * ((double)m_level / 100)) + 10 + m_level);
            m_Attack = (int)((((m_attIV + 2 * m_baseAttack + ((double)m_attEV / 4)) * ((double)m_level / 100)) + 5) * GetNature().GetAttackMod());
            m_SpAttack = (int)((((m_spAttIV + 2 * m_baseSpAttack + ((double)m_spAttEV / 4)) * ((double)m_level / 100)) + 5) * GetNature().GetSpAttackMod());
            m_Defense = (int)((((m_defIV + 2 * m_baseDefense + ((double)m_defEV / 4)) * ((double)m_level / 100)) + 5) * GetNature().GetDefenseMod());
            m_SpDefense = (int)((((m_spDefIV + 2 * m_baseSpDefense + ((double)m_spDefEV / 4)) * ((double)m_level / 100)) + 5) * GetNature().GetSpDefenseMod());
            m_Speed = (int)((((m_speedIV + 2 * m_baseSpeed + ((double)m_speedEV / 4)) * ((double)m_level / 100)) + 5) * GetNature().GetSpeedMod());
            m_currentHP = m_HP;
        }

        /// <summary>
        /// This sets the base stats of the Pokemon and then calls SetStats()
        /// </summary>
        /// <param name="hp">The base HP stat of the Pokemon.</param>
        /// <param name="att">The base Attack stat of the Pokemon.</param>
        /// <param name="spAtt">The base Special Attack stat of the Pokemon.</param>
        /// <param name="def">The base Defense stat of the Pokemon.</param>
        /// <param name="spDef">The base Special Defense stat of the Pokemon.</param>
        /// <param name="spd">The base Speed stat of the Pokemon.</param>
        public void SetBaseStats(int hp, int att, int spAtt, int def, int spDef, int spd)
		{
			m_baseHealth = hp;
			m_baseAttack = att;
			m_baseSpAttack = spAtt;
			m_baseDefense = def;
			m_baseSpDefense = spDef;
			m_baseSpeed = spd;
			SetStats();
		}

        /// <summary>
        /// Returns Base HP stat
        /// </summary>
        /// <returns>int m_baseHealth: Base HP stat</returns>
        public int GetBaseHP()
        {
            return m_baseHealth;
        }

        /// <summary>
        /// Returns Base Attack stat
        /// </summary>
        /// <returns>int m_baseAttack: Base Attack stat</returns>
        public int GetBaseAttack()
        {
            return m_baseAttack;
        }

        /// <summary>
        /// Returns base Special Attack stat
        /// </summary>
        /// <returns>int m_baseSpAttack: Base Special Attack Stat</returns>
        public int GetBaseSpAttack()
        {
            return m_baseSpAttack;
        }

        /// <summary>
        /// Returns Base Defense Stat
        /// </summary>
        /// <returns>int m_baseDefense: Base Defense stat</returns>
        public int GetBaseDefense()
        {
            return m_baseDefense;
        }

        /// <summary>
        /// Returns Base Special Defense
        /// </summary>
        /// <returns>int m_baseSpDefense: Base Special Defense</returns>
        public int GetBaseSpDefense()
        {
            return m_baseSpDefense;
        }

        /// <summary>
        /// Returns the Base Speed stat
        /// </summary>
        /// <returns>int m_baseSpeed: Base Speed</returns>
        public int GetBaseSpeed()
        {
            return m_baseSpeed;
        }

        /// <summary>
        /// Returns hp IV
        /// </summary>
        /// <returns>Hp Individual Value</returns>
        public int GetHpIV()
        {
            return m_hpIV;
        }

        /// <summary>
        /// Returns attIV
        /// </summary>
        /// <returns>Attack IV</returns>
        public int GetAttackIV()
        {
            return m_attIV;
        }		

        /// <summary>
        /// returns spAttIV
        /// </summary>
        /// <returns>Special Attack IV</returns>
        public int GetSpAttIV()
        {
            return m_spAttIV;
        }		
		
        /// <summary>
        /// Returns defIV
        /// </summary>
        /// <returns>Defense IV</returns>
        public int GetDefenseIV()
        {
            return m_defIV;
        }		
		
        /// <summary>
        /// Returns spDefIV
        /// </summary>
        /// <returns>Special Defense IV</returns>
        public int GetSpDefIV()
        {
            return m_spDefIV;
        }		
		
        /// <summary>
        /// Returns speedIV
        /// </summary>
        /// <returns>Speed IV</returns>
        public int GetSpeedIV()
        {
            return m_speedIV;
        }		

		/// <summary>
		/// Returns Hp Effort Values
		/// </summary>
		/// <returns>m_hpEV</returns>
        public int GetHpEV()
        {
            return m_hpEV;
        }

		/// <summary>
		/// Returns Attack EVs
		/// </summary>
		/// <returns>m_attEV</returns>
        public int GetAttackEV()
        {
            return m_attEV;
        }		
		
		/// <summary>
		/// Returns Special Attack EVs
		/// </summary>
		/// <returns>m_spAttEV</returns>
        public int GetSpAttEV()
        {
            return m_spAttEV;
        }		
		
		/// <summary>
		/// Returns Defense EVs
		/// </summary>
		/// <returns>m_defEV</returns>
        public int GetDefenseEV()
        {
            return m_defEV;
        }
		
		/// <summary>
		/// Returns Special Defense EVs
		/// </summary>
		/// <returns>m_spDefEV</returns>
        public int GetSpDefEV()
        {
            return m_spDefEV;
        }
		
		/// <summary>
		/// Returns Speed EVs
		/// </summary>
		/// <returns>m_speedEV</returns>
        public int GetSpeedEV()
        {
            return m_speedEV;
        }		

        /// <summary>
        /// Returns the Nature of the Pokemon
        /// </summary>
        /// <returns>m_nature</returns>
        public Nature GetNature()
        {
            return m_nature;
        }

		/// <summary>
		/// Returns the first type of the Pokemon as an int value.
		/// </summary>
		/// <returns>m_type1</returns>
        public int GetType1()
        {
            return m_type1;
        }

		/// <summary>
		/// Returns the second type of the Pokemon as an int value
		/// </summary>
		/// <returns>m_type2</returns>
        public int GetType2()
        {
            return m_type2;
        }

		/// <summary>
		/// Returns the Classification of the Pokemon as a string.
		/// </summary>
		/// <returns>m_classification</returns>
        public string GetClassification()
        {
            return m_classification;
        }

		/// <summary>
		/// Returns the name of the species of Pokemon as a string.
		/// </summary>
		/// <returns>m_name</returns>
        public string GetName()
        {
            return m_name;
        }

		/// <summary>
		/// Returns the nickname of the Pokemon as a string.
		/// </summary>
		/// <returns>m_nickname</returns>
        public string GetNickName()
        {
            return m_nickname;
        }

		/// <summary>
		/// Sets the EVs of the Pokemon to 0. Used during Pokemon Creation.
		/// </summary>
        private void SetEVs()
        {	
	        // EV codes
	        m_hpEV =	0;	// HP Effort Values
	        m_attEV =	0;	// Attack Effort Values (EV)
	        m_spAttEV =	0;	// Special Attack Effort Values (EV)
	        m_defEV =	0;	// Defense Effort Values (EV)
	        m_spDefEV =	0;	// Special Defense Effort Values (EV)
	        m_speedEV =	0;	// Speed Effort Values (EV)
        }

		/// <summary>
		/// Sets the first type of the pokemon to the parameter
		/// </summary>
		/// <param name="type1">The new first type of the Pokemon.</param>
        public void SetType1(int type1)
        {
            m_type1 = type1;
        }	

		/// <summary>
		/// Changes the second type of the Pokemon to the parameter type2
		/// </summary>
		/// <param name="type2">The new second type of the Pokemon.</param>
        public void SetType2(int type2)
        {
            m_type2 = type2;
        }
		
        /// <summary>
        /// Returns a random value between nLow and nHigh inclusive.
        /// </summary>
        /// <param name="nLow">Low value</param>
        /// <param name="nHigh">High value</param>
        /// <returns>An int between nLow and nHigh inclusive</returns>
        public static int GetRandom(int nLow, int nHigh)
        {
            return random.Next(nLow - 1, nHigh) + 1;
        }

        public void SetCurrentHPRandom()
        {
            m_currentHP = GetRandom(1, m_HP);
        }

        public void SetCurrentHP(int currentHP)
        {
            m_currentHP = currentHP;
        }

		/// <summary>
		/// Checks the effectiveness of the move to the targetType. Uses nested switch-case statements, so is not commented.
		/// </summary>
		/// <param name="moveType">The type of the move.</param>
		/// <param name="targetType">The type of the target Pokemon.</param>
		/// <returns>A double value between 0.0 and 2.0. This is used during damage calculations.</returns>
        public double CheckTypeEffective(int moveType, int targetType)
        {
            double effectiveness = 1.0;

            switch (moveType)
            {
                case FIRE:
                    switch (targetType)
                    {
                        case GRASS:
                            effectiveness *= 2.0;
                            break;
                        case ICE:
                            effectiveness *= 2.0;
                            break;
                        case STEEL:
                            effectiveness *= 2.0;
                            break;
                        case BUG:
                            effectiveness *= 2.0;
                            break;
                        case FIRE:
                            effectiveness *= 0.5;
                            break;
                        case WATER:
                            effectiveness *= 0.5;
                            break;
                        case ROCK:
                            effectiveness *= 0.5;
                            break;
                        case DRAGON:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case FIGHTING:
                    switch (targetType)
                    {
                        case NORMAL:
                            effectiveness *= 2.0;
                            break;
                        case ICE:
                            effectiveness *= 2.0;
                            break;
                        case DARK:
                            effectiveness *= 2.0;
                            break;
                        case ROCK:
                            effectiveness *= 2.0;
                            break;
                        case STEEL:
                            effectiveness *= 2.0;
                            break;
                        case POISON:
                            effectiveness *= 0.5;
                            break;
                        case FLYING:
                            effectiveness *= 0.5;
                            break;
                        case PSYCHIC:
                            effectiveness *= 0.5;
                            break;
                        case BUG:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case NORMAL:
                    switch (targetType)
                    {
                        case FIGHTING:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case GHOST:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case WATER:
                    switch (targetType)
                    {
                        case FIRE:
                            effectiveness *= 2.0;
                            break;
                        case GROUND:
                            effectiveness *= 2.0;
                            break;
                        case ROCK:
                            effectiveness *= 2.0;
                            break;
                        case WATER:
                            effectiveness *= 0.5;
                            break;
                        case GRASS:
                            effectiveness *= 0.5;
                            break;
                        case DRAGON:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case ICE:
                    switch (targetType)
                    {
                        case GRASS:
                            effectiveness *= 2.0;
                            break;
                        case GROUND:
                            effectiveness *= 2.0;
                            break;
                        case FLYING:
                            effectiveness *= 2.0;
                            break;
                        case DRAGON:
                            effectiveness *= 2.0;
                            break;
                        case WATER:
                            effectiveness *= 0.5;
                            break;
                        case FIRE:
                            effectiveness *= 0.5;
                            break;
                        case ICE:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case GRASS:
                    switch (targetType)
                    {
                        case WATER:
                            effectiveness *= 2.0;
                            break;
                        case GROUND:
                            effectiveness *= 2.0;
                            break;
                        case ROCK:
                            effectiveness *= 2.0;
                            break;
                        case FIRE:
                            effectiveness *= 0.5;
                            break;
                        case GRASS:
                            effectiveness *= 0.5;
                            break;
                        case POISON:
                            effectiveness *= 0.5;
                            break;
                        case FLYING:
                            effectiveness *= 0.5;
                            break;
                        case BUG:
                            effectiveness *= 0.5;
                            break;
                        case DRAGON:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case BUG:
                    switch (targetType)
                    {
                        case PSYCHIC:
                            effectiveness *= 2.0;
                            break;
                        case GRASS:
                            effectiveness *= 2.0;
                            break;
                        case DARK:
                            effectiveness *= 2.0;
                            break;
                        case FIRE:
                            effectiveness *= 0.5;
                            break;
                        case FIGHTING:
                            effectiveness *= 0.5;
                            break;
                        case POISON:
                            effectiveness *= 0.5;
                            break;
                        case GHOST:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case POISON:
                    switch (targetType)
                    {
                        case GRASS:
                            effectiveness *= 2.0;
                            break;
                        case GROUND:
                            effectiveness *= 0.5;
                            break;
                        case ROCK:
                            effectiveness *= 0.5;
                            break;
                        case POISON:
                            effectiveness *= 0.5;
                            break;
                        case GHOST:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case FLYING:
                    switch (targetType)
                    {
                        case GRASS:
                            effectiveness *= 2.0;
                            break;
                        case BUG:
                            effectiveness *= 2.0;
                            break;
                        case FIGHTING:
                            effectiveness *= 2.0;
                            break;
                        case ELECTRIC:
                            effectiveness *= 0.5;
                            break;
                        case ROCK:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case PSYCHIC:
                    switch (targetType)
                    {
                        case POISON:
                            effectiveness *= 2.0;
                            break;
                        case FIGHTING:
                            effectiveness *= 2.0;
                            break;
                        case PSYCHIC:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case DARK:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case GHOST:
                    switch (targetType)
                    {
                        case PSYCHIC:
                            effectiveness *= 2.0;
                            break;
                        case GHOST:
                            effectiveness *= 2.0;
                            break;
                        case DARK:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case NORMAL:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case DARK:
                    switch (targetType)
                    {
                        case PSYCHIC:
                            effectiveness *= 2.0;
                            break;
                        case GHOST:
                            effectiveness *= 2.0;
                            break;
                        case FIGHTING:
                            effectiveness *= 0.5;
                            break;
                        case DARK:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case GROUND:
                    switch (targetType)
                    {
                        case FIRE:
                            effectiveness *= 2.0;
                            break;
                        case ELECTRIC:
                            effectiveness *= 2.0;
                            break;
                        case POISON:
                            effectiveness *= 2.0;
                            break;
                        case ROCK:
                            effectiveness *= 2.0;
                            break;
                        case STEEL:
                            effectiveness *= 2.0;
                            break;
                        case WATER:
                            effectiveness *= 0.5;
                            break;
                        case GRASS:
                            effectiveness *= 0.5;
                            break;
                        case ICE:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case FLYING:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case STEEL:
                    switch (targetType)
                    {
                        case ICE:
                            effectiveness *= 2.0;
                            break;
                        case BUG:
                            effectiveness *= 2.0;
                            break;
                        case FIRE:
                            effectiveness *= 0.5;
                            break;
                        case GROUND:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case ROCK:
                    switch (targetType)
                    {
                        case FIRE:
                            effectiveness *= 2.0;
                            break;
                        case ICE:
                            effectiveness *= 2.0;
                            break;
                        case FLYING:
                            effectiveness *= 2.0;
                            break;
                        case BUG:
                            effectiveness *= 2.0;
                            break;
                        case FIGHTING:
                            effectiveness *= 0.5;
                            break;
                        case GROUND:
                            effectiveness *= 0.5;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case ELECTRIC:
                    switch (targetType)
                    {
                        case WATER:
                            effectiveness *= 2.0;
                            break;
                        case FLYING:
                            effectiveness *= 2.0;
                            break;
                        case ELECTRIC:
                            effectiveness *= 0.5;
                            break;
                        case GRASS:
                            effectiveness *= 0.5;
                            break;
                        case DRAGON:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        case GROUND:
                            effectiveness *= 0.0;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case DRAGON:
                    switch (targetType)
                    {
                        case DRAGON:
                            effectiveness *= 2.0;
                            break;
                        case STEEL:
                            effectiveness *= 0.5;
                            break;
                        case SHADOW:
                            effectiveness *= 0.5;
                            break;
                        default:
                            effectiveness *= 1.0;
                            break;
                    }
                    break;
                case SHADOW:
                    switch (targetType)
                    {
                        case SHADOW:
                            effectiveness *= 1.0;
                            break;
                        default:
                            effectiveness *= 2.0;
                            break;
                    }
                    break;
            }


            return effectiveness;
        }

        /// <summary>
        /// Checks the effectiveness of the Move to the target Pokemon. 
        /// </summary>
        /// <param name="usingMove">The move used by the user.</param>
        /// <param name="target">The target Pokemon.</param>
        /// <returns>A double value between 0.0 and 4.0.</returns>
        double CheckEffectiveness(Move usingMove, Pokemon target)
        {
            double effectiveness = 1.0;

            // sets selfType to the move's type;
            int selfType = usingMove.GetTyping();

            // sets placeholder int to the target's first type
            int targetType1 = target.GetType1();

            // sets placeholder int to the target's second type
            int targetType2 = target.GetType2();

            // First run of the CheckTypeEffective
            effectiveness *= CheckTypeEffective(selfType, targetType1);

            // Second Run of the Check TYpe Effective
            effectiveness *= CheckTypeEffective(selfType, targetType2);

            return effectiveness;
        }

        /// <summary>
        /// Returns a boolean value based on if the Pokemon can evolve. True if yes.
        /// </summary>
        /// <returns>bool m_canEvolve</returns>
        public bool CanEvolve()
        {
            return m_canEvolve;
        }

        /// <summary>
        /// Returns an int that tells how the Pokemon evolves. See const table above.
        /// </summary>
        /// <returns>int m_howEvolves</returns>
        public int MethodOfEvolution()
        {
            return m_howEvolves;
        }

        /// <summary>
        /// This will evolve the Pokemon internally.
        /// </summary>
        public void Evolve()
        {
            m_baseAttack = m_evolution.GetBaseAttack();
            m_baseDefense = m_evolution.GetBaseDefense();
            m_baseHealth = m_evolution.GetBaseHP();
            m_baseSpAttack = m_evolution.GetBaseSpAttack();
            m_baseSpDefense = m_evolution.GetBaseSpDefense();
            m_baseSpeed = m_evolution.GetBaseSpeed();
            m_name = m_evolution.GetName();
            m_evolution = m_evolution.GetEvolution();
            
        }

        /// <summary>
        /// Returns the Evolution of the Pokemon
        /// </summary>
        /// <returns>Pokemon m_evolution: the Evolution of the Pokemon</returns>
        public Pokemon GetEvolution()
        {
            return m_evolution;
        }

        /// <summary>
        /// Returns the Pokemon's max HP
        /// </summary>
        /// <returns>int m_HP</returns>
        public int GetMaxHP()
        {
            return m_HP;
        }

        /// <summary>
        /// Returns current HP. If it goes below zero, m_isFainted Flag toggles!
        /// </summary>
        /// <returns>int m_currentHP</returns>
        public int GetCurrentHP()
        {
            return m_currentHP;
        }

        /// <summary>
        /// Returns the Catch Rate of the Pokemon
        /// </summary>
        /// <returns>int m_catchRate: 1 to 255</returns>
        public int GetCatchRate()
        {
            return m_catchRate;
        }

        /// <summary>
        /// Returns the Pokemon's status in terms of fainted/!fainted
        /// </summary>
        /// <returns>bool m_isFainted: true if the m_currentHP == 0</returns>
        public bool GetFainted()
        {
            return m_isFainted;
        }

        /// <summary>
        /// Returns a double value based on status that the Pokeball class uses to calculate capture rate.
        /// </summary>
        /// <returns>double based on status: 1.0, 1.5, or 2.0</returns>
        public double GetStatusModifier()
        {
            double modif = 1.0;

            switch (m_status)
            {
                case FROZEN:
                case SLEEPING:
                case BAD_POISON:
                    modif = 2.0;
                    break;
                case PARALYZED:
                case BURNED:
                case POISONED:
                    modif = 1.5;
                    break;
                default:
                    break;
            }
 

            return modif;
        }

        /// <summary>
        /// Sets the Pokemon's Ownership boolean to isBoolean
        /// </summary>
        /// <param name="isBoolean">true if owned, false if wild</param>
        public void SetOwned(bool isBoolean)
        {
            m_owned = isBoolean;
        }

        /// <summary>
        /// Adds the Move moveToAdd to Move Pool
        /// </summary>
        /// <param name="moveToAdd">The Move to add to the Move Pool</param>
        public void AddMovePool(Move moveToAdd)
        {
            m_moveCanKnowList.Add(moveToAdd);
        }

        /// <summary>
        /// Adds the Move moveToAdd to the usable moves.
        /// </summary>
        /// <param name="moveToAdd">The Move to add to the usable list of Moves.</param>
        public void AddMoveToUsable(Move moveToAdd)
        {
            if (m_moveCanKnowList.Contains(moveToAdd))
            {
                m_moveKnowsList.Add(moveToAdd);
            }
            else
            {
                Console.WriteLine("Error: Pokemon cannot learn this move.");
            }

        }

        /// <summary>
        /// Returns the Pokemon's Happiness value
        /// </summary>
        /// <returns>int m_happiness: How happy the Pokemon is.</returns>
        public int GetHappiness()
        {
            return m_happiness;
        }

	}


}
