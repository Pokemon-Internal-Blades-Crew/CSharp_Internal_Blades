using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp
{
    class Constants
    {
        /// <summary>
        /// Defines all constants needed for entire program
        /// </summary>

        
        
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
    }
}
