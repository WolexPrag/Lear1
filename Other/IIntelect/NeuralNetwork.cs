using System.Collections.Generic;
using System.Linq;

namespace Learn1.Other.IIntelect
{
    public class NeuralNetwork
    {
        public Topology topology { get; }
        public List<Layer> layers { get; }
        public NeuralNetwork(Topology topology)
        {
            this.topology = topology;

            layers = new List<Layer>();

            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();

        }

        public Neuron FeedForward(List<double> inputsSignals)
        {
            SendSignalsToInputNeurons(inputsSignals);
            FeedForwardAllLayersAfterInput();

            if (topology.outputCount == 1)
            {
                return layers.Last().neurons[0];
            }
            else
            {
                return layers.Last().neurons.OrderByDescending(n => n.output).First();
            }
        }
        public List<Neuron> FeedForwards(List<double> inputsSignals)
        {
            SendSignalsToInputNeurons(inputsSignals);
            FeedForwardAllLayersAfterInput();

            return layers.Last().neurons;
        }
        private void FeedForwardAllLayersAfterInput()
        {
            for (int i = 1; i < layers.Count; i++)
            {
                var layer = layers[i];
                var previousLayerSignals = layers[i - 1].GetSignals();

                foreach (var neuron in layer.neurons)
                {
                    neuron.FeedForward(previousLayerSignals);
                }
            }
        }

        private void SendSignalsToInputNeurons(List<double> inputsSignals)
        {
            for (int i = 0; i < inputsSignals.Count; i++)
            {
                var signal = new List<double>() { inputsSignals[i] };
                var neuron = layers[0].neurons[i];

                neuron.FeedForward(signal);
            }
        }

        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();
            for (int i = 0; i < topology.inputCount; i++)
            {
                Neuron neuron = new Neuron(1, NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            var inputLayer = new Layer(inputNeurons, NeuronType.Input);
            layers.Add(inputLayer);
        }

        private void CreateHiddenLayers()
        {
            for (int j = 0; j < topology.hiddenLayers.Count; j++)
            {


                var hiddenNeurons = new List<Neuron>();
                var lastLayer = layers.Last();
                for (int i = 0; i < topology.hiddenLayers[j]; i++)
                {
                    Neuron neuron = new Neuron(lastLayer.count);
                    hiddenNeurons.Add(neuron);
                }
                var hiddenLayer = new Layer(hiddenNeurons);
                layers.Add(hiddenLayer);
            }
        }

        private void CreateOutputLayer()
        {
            var outputNeurons = new List<Neuron>();
            var lastLayer = layers.Last();
            for (int i = 0; i < topology.outputCount; i++)
            {
                Neuron neuron = new Neuron(lastLayer.count, NeuronType.Output);
                outputNeurons.Add(neuron);
            }
            var outputLayer = new Layer(outputNeurons, NeuronType.Output);
            layers.Add(outputLayer);
        }
    }
}
