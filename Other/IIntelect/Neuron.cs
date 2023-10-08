using System;
using System.Collections.Generic;
namespace Learn1.Other.IIntelect
{
    public class Neuron
    {
        public List<double> weights;
        public NeuronType neuronType;
        public double output;
        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            neuronType = type;
            weights = new List<double>();
            for (int i = 0; i < inputCount; i++)
            {
                weights.Add(1);
            }
        }
        public double FeedForward(List<double> inputs) 
        {
            double sum = 0f;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum = sum + inputs[i] * weights[i];
            }
            if (neuronType != NeuronType.Input)
            { 
                output = Sigmoid(sum);
            }
            else
            {
                output = sum;
            }
            return output;
        }
        public void SetWeights(params double[] weights) 
        {
            for (int i = 0; i < weights.Length; i++)
            {
                this.weights[i] = weights[i];
            }
        }

        public double Sigmoid(double x) 
        {
            return 1f / (1f + Math.Pow(Math.E, -x));
        }
        public override string ToString()
        {
            return output.ToString();
        }
    }
    
}
