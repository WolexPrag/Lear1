using System;
using System.Collections.Generic;

namespace Learn1.Other.IIntelect
{
    public class Layer
    {
        public List<Neuron> neurons { get; }
        public int count => neurons?.Count ?? 0;
        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            for (int i = 0; i < neurons.Count; i++)
            {
                if (neurons[i].neuronType != type)
                {
                    throw new Exception(message:"Not Correct Type Neurons");
                }
            }
            this.neurons = neurons;

        }
        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in neurons)
            {
                result.Add(neuron.output);
            }
            return result;
        }
    }
}
