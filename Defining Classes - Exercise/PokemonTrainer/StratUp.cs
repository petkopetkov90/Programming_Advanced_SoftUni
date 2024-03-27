namespace PokemonTrainer
{
    internal class StratUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainersPokemonts = new Dictionary<string, Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] pokemonsInfor = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonsInfor[0];
                string pokemonName = pokemonsInfor[1];
                string pokemonElement = pokemonsInfor[2];
                int pokemonHealth = int.Parse(pokemonsInfor[3]);

                if (!trainersPokemonts.ContainsKey(trainerName))
                {
                    trainersPokemonts.Add(trainerName, new Trainer(trainerName));
                }

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainersPokemonts[trainerName].Pokemons.Add(currentPokemon);
            }

            string element;
            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainersPokemonts.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons = trainer.Pokemons.FindAll(p => p.Health > 0);
                    }
                }
            }

            foreach (var trainerKVP in trainersPokemonts.OrderByDescending(t => t.Value.NumberOfBadges))
            {
                Console.WriteLine(trainerKVP.Value);
            }
        }
    }
}
