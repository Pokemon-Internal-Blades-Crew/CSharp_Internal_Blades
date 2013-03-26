using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        // ---------------------------------------------------------------------------------------------------------------------

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
        const int NORMAL		=	1;

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
        const int POISON		=	8;

        /// <summary>
        /// Flying Type
        /// Supereffective Against:			Bug, Grass, Fighting		
        /// Half Damage Dealt:				Electric, Rock, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Ground
        /// </summary>
        const int FLYING		=	9;

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
        const int GROUND		=	13;

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
        const int DRAGON		=	17;

        /// <summary>
        /// Shadow Type
        /// Supereffective Against:			All but Shadow		
        /// Half Damage Dealt:				Shadow
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int SHADOW		=	18;

        /// <summary>
        /// ??? Type
        /// Supereffective Against:			N/A
        /// Double Damage taken:			N/A
        /// Half Damage Dealt:				N/A
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int UNKNOWN	=	19;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Base MP of 5
        /// </summary>
        const int LOW_MP		=	5;

        /// <summary>
        /// Base MP of 10
        /// </summary>
        const int LOW_MED_MP	=	10;

        /// <summary>
        /// Base MP of 15
        /// </summary>
        const int MEDIUM_MP	=	15;

        /// <summary>
        /// Base MP of 20
        /// </summary>
        const int MED_HIGH_MP =	20;

        /// <summary>
        /// Base MP of 30
        /// </summary>
        const int HIGH_MP	=	30;

        // ---------------------------------------------------------------------------------------------------------------------

        // Nature Definitions
        // Used to modify stats in Nature Class

        /// <summary>
        /// Increases the stat by 1.1
        /// </summary>
        const double INCREASE_STAT =	1.1;

        /// <summary>
        /// Normal Stat: 1.0
        /// </summary>
        const double NORMAL_STAT	  =	1.0;

        /// <summary>
        /// Decreases the stat by 0.9
        /// </summary>
        const double DECREASE_STAT =	0.9;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// True
        /// </summary>
        const bool YES			=	true;

        /// <summary>
        /// False
        /// </summary>
        const bool NO			=	false;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Blank Name Definition
        ///	Defines EMPTY as ""
        /// </summary>
        const string EMPTY			=   " ";

        // ---------------------------------------------------------------------------------------------------------------------

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
        const int BURNED			=   3;

        /// <summary>
        /// Frozen Effects: The Pokémon cannot use any attacks (apart from those that thaw it)
        /// </summary>
        const int FROZEN			=   4;

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
        const int CURSED			=   8;

        /// <summary>
        /// Badly Poisoned Effects: The Pokémon loses 1/16th Max HP for the first turn and then adds 1/16th to the amount to be lost 
        ///  so on 2nd turn 2/16th, 3rd 3/16th and so on until the Pokémon faints
        /// </summary>
        const int BAD_POISON		=   9;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Gender Definition: Male
        /// </summary>
        const int MALE			=   0;

        /// <summary>
        /// Gender Definition: Female
        /// </summary>
        const int FEMALE			=   1;

        // ---------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default Trainer ID Definition
        /// </summary>
        const long DEFAULT_ID	=	100000;

        private Random random = new Random();
        
        

        private Move[]		m_moveCanKnowList;
        private Move[]      m_moveKnowsList;
        private Move[]      m_eggMoves;

        private Move        m_moveUsing;


		private string		m_name;				// Pokemon Name
		private string		m_nickname;			// Nickname given to Pokemon. Default should be m_name
		private string		m_classification;	// The Classification of the Pokemon. IE. Espeon: 'The Sun Pokemon'

		private Ability		m_ability1;			// First ability
		private Ability		m_ability2;			// Second ability
		private Ability		m_abilityHidden1;	// Third ability
		private Ability		m_abilityHidden2;	// Fourth ability
		
		private Nature		m_nature;			// Nature of the Pokemon

		 private int	m_health;			// from 0 to 999
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
		private double		m_damage;			// Damage value
		//private double		m_stab;				// Same Type Attack Bonus
		private double		m_effectiveness;	// Effectiveness against target.

		private bool		m_owned;			// Tells if owned. Default to wild: false
		private bool		m_isFainted;		// Tells if the Pokemon is fainted. Default is false.

		private int			m_type1;			// First type.  Default is NORMAL
		private int			m_type2;			// Second Type. Default is NONE

		private int	        m_happiness;		// Happiness Value from 0 to 255


        /// <summary>
        /// Sets IV's
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
        /// Set Actual Stats
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="classification"></param>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <param name="owned"></param>
        /// <param name="level"></param>
		public Pokemon(string name, string classification, int type1, int type2, bool owned, int level)
        {
            m_name = name;		// Sets the Pokemon's name to name
            m_nickname = name;
            m_classification = classification;	// Sets the pokemon's classification to classification.
            m_isFainted = NO;	// Automatic is not fainted
            m_owned = owned;	// Set owned status. True is trainer, false is wild.
            m_type1 = type1;	// Set first type.
            m_type2 = type2;	// Set second type. If in real game, this does not exist, type2 is NONE.
            m_level = level;
            m_happiness = 90;
            m_ability1 = new Ability();
            m_ability2 = new Ability();
            m_abilityHidden1 = new Ability();
            m_abilityHidden2 = new Ability();
            m_nature = new Nature();
            SetIVs();
            SetEVs();
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Pokemon()	
		{
            m_level = 5;
			m_name = EMPTY;
			m_owned = NO;
			m_type1 = NORMAL;
			m_type2 = NONE;
            m_isFainted = NO;
			SetIVs();
			SetEVs();
            m_ability1 = new Ability();
            m_ability2 = new Ability();
            m_abilityHidden1 = new Ability();
            m_abilityHidden2 = new Ability();
            m_nature = new Nature();
            m_happiness = 90;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="att"></param>
        /// <param name="spAtt"></param>
        /// <param name="def"></param>
        /// <param name="spDef"></param>
        /// <param name="spd"></param>
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
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetHpEV()
        {
            return m_hpEV;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetAttackEV()
        {
            return m_attEV;
        }		
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetSpAttEV()
        {
            return m_spAttEV;
        }		
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetDefenseEV()
        {
            return m_defEV;
        }
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetSpDefEV()
        {
            return m_spDefEV;
        }
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetSpeedEV()
        {
            return m_speedEV;
        }		

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Nature GetNature()
        {
            return m_nature;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetType1()
        {
            return m_type1;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public int GetType2()
        {
            return m_type2;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public string GetClassification()
        {
            return m_classification;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public string GetName()
        {
            return m_name;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        public string GetNickName()
        {
            return m_nickname;
        }


		/// <summary>
		/// 
		/// </summary>
        public void SetEVs()
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
		/// 
		/// </summary>
		/// <param name="type1"></param>
        public void SetType1(int type1)
        {
            m_type1 = type1;
        }	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type2"></param>
        public void SetType2(int type2)
        {
            m_type2 = type2;
        }
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nLow"></param>
        /// <param name="nHigh"></param>
        /// <returns></returns>
        public int GetRandom(int nLow, int nHigh)
        {
            return random.Next(nLow - 1, nHigh) + 1;
        }	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="moveType"></param>
		/// <param name="targetType"></param>
		/// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="usingMove"></param>
        /// <param name="target"></param>
        /// <returns></returns>
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
		
	}
}
