using System.Collections.Generic;

namespace Learn1.Other.IIntelect
{
    public class Topology
    {
        public int inputCount { get; }
        public int outputCount { get; }
        public List<int> hiddenLayers { get; }
        public Topology(int inputCount, int outputCount, params int[] layers)
        {
            this.inputCount = inputCount;
            this.outputCount = outputCount;
            this.hiddenLayers = new List<int>();
            hiddenLayers.AddRange(layers);
        }
    }
}
