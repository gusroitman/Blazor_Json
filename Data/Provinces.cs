namespace BlazorCrud.Data
{
    public class Provinces
    {
        public string Name { get; set; }

        public string Capital { get; set; }

        public uint Population { get; set; }

        public uint Territory { get; set; }
/*
        public int Density => (int)(Population / Territory);

        public int PTotalPopulation { get; set; }

        public int PTotalTerritory { get; set; }
*/
    }
}
