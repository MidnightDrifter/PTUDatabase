using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUDatabase.Classes
{
    public record Pokemon
    {
        /*
         * Pokmeon have:
         * Species name
         * Regular / given name?
         * Movelist
         * Type
         * Nature
         * Forms
         * Capabilities
         * Abilities
         * Stat block
         * Level + current XP
         * Skills
         * Edges?
         * Held Item?
         */

        public Species SpeciesName { get; init; }
        public String CharacterName { get; init; } = "Nugget Boi";

        public IList<PokemonType> PokemonTypes { get; init; } = Array.Empty<PokemonType>();


        //Not sure how Yota is tying Moves + Move Requirements + Move Ranges (+ Contest Effects??) together, skipping for now


        public Nature Nature { get; init; } = Nature.Sassy;

        public Form Forms { get; init; }  //Initialize to NULL?

        public Capabilities Capabilities { get; init; }  //These get pulled from the CSV?

        public IList<Ability> Abilities { get; init; } = Array.Empty<Ability>();

        public Stats Stats { get; init; }  //Get pulled from CSV / YAML

        public int Level { get; set; }

        public Skills Skills { get; init; } = Skills.Minimum;

        //Edges and Held Items yet to be implemented?

    }
}
