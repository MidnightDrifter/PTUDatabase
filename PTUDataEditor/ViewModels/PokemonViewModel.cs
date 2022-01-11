using PTUDatabase;

namespace PTUDataEditor.ViewModels
{
    public class PokemonViewModel : ViewModelBase
    {
        public Pokemon Model
        {
            get => new()
            {

                SpeciesName = SpeciesName,
                CharacterName = CharacterName,
                PokemonTypes = PokemonTypes,
                Nature = Nature,
                Forms = Forms,
                Capabilities = Capabilities,
                Abilities = Abilities,
                Stats = Stats,
                Level = Level,
                Skills = Skills

                //Moves, Edges (?), and Held Items still need added

            };
            private set
            {
                SpeciesName = value.SpeciesName;
                CharacterName = value.CharacterName;
                PokemonTypes = value.PokemonTypes;
                Nature = value.Nature;
                Forms = value.Forms;
                Capabilities = value.Capabilities;
                Abilities = value.Abilities;
                Stats = value.Stats;
                Level = value.Level;
                Skills = value.Skills;
            }
        }


        public PokemonViewModel(Pokemon model)
        {
            Model = model;
        }


    }
}
