using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyCognitiveMap {
    public class FCM {
        private string[] concepts;
        private double[,] weigths;
        public string[] Concepts { get => concepts; set => concepts = value; }
        public double[,] Weigths { get => weigths; set => weigths = value; }
        public void AddConcept(string concept) {

            // Rearange concepts
            string[] new_concepts = new string[Concepts.GetLength(0) + 1];
            new_concepts[new_concepts.Length - 1] = Concepts[Concepts.Length - 1];
            new_concepts[new_concepts.Length - 2] = concept;
            for (int i = 0; i < new_concepts.Length - 2; i++) {
                new_concepts[i] = Concepts[i];
            }
            Concepts = new_concepts;

            // Rearange weights
            double[,] new_weights = new double[Weigths.GetLength(0) + 1, Weigths.GetLength(1) + 1];
            for (int i = 0; i < new_weights.GetLength(0) - 2; i++) {//1
                for (int j = 0; j < new_weights.GetLength(1) - 2; j++) {
                    new_weights[i, j] = Weigths[i, j];
                }
            }
            for (int j = 0; j < new_weights.GetLength(0) - 2; j++) { //2
                new_weights[new_weights.GetLength(0) - 1, j] = Weigths[Weigths.GetLength(0) - 1, j];
            }
            for (int i = 0; i < new_weights.GetLength(0) - 2; i++) { //3
                new_weights[i, new_weights.GetLength(0) - 1] = Weigths[i, Weigths.GetLength(0) - 1];
            }
            new_weights[new_weights.GetLength(0) - 2, new_weights.GetLength(0) - 2] = 1;//4
            new_weights[new_weights.GetLength(0) - 1, new_weights.GetLength(0) - 1] = 1;//5
            Weigths = new_weights;
        }

        public void EditConcept(int i, string new_concept) {
            new_concept = new_concept.Trim(' ');
            if (new_concept == "") {
                throw new Exception("Concept name cannot be empty.");
            }
            Concepts[i] = new_concept;
        }

        public void RemoveConcept(int I) {

            if (I == Concepts.Length - 1 || Concepts.Length <= 1) {
                throw new Exception("Concept index cannot be the last.");
            }

            // Rearange concepts
            string[] new_concepts = new string[Concepts.GetLength(0) - 1];
            for (int j = 0; j < I; j++) {
                new_concepts[j] = Concepts[j];
            }
            for (int j = I; j < new_concepts.Length; j++) {
                new_concepts[j] = Concepts[j + 1];
            }
            Concepts = new_concepts;

            // Rearange weights
            double[,] new_weights = new double[Weigths.GetLength(0) - 1, Weigths.GetLength(1) - 1];
            for (int i = 0; i < I; i++) {//1
                for (int j = 0; j < I; j++) {
                    new_weights[i, j] = Weigths[i, j];
                }
            }
            for (int i = I; i < new_weights.GetLength(0); i++) {//2
                for (int j = 0; j < I; j++) {
                    new_weights[i, j] = Weigths[i + 1, j];
                }
            }
            for (int i = 0; i < I; i++) {//3
                for (int j = I; j < new_weights.GetLength(1); j++) {
                    new_weights[i, j] = Weigths[i, j + 1];
                }
            }
            for (int i = I; i < new_weights.GetLength(0); i++) {//4
                for (int j = I; j < new_weights.GetLength(1); j++) {
                    new_weights[i, j] = Weigths[i + 1, j + 1];
                }
            }
            Weigths = new_weights;
        }
        public void EditWeigth(int I, int J, double value) {

            if (I == J) {
                throw new Exception("Not possible");
            }

            if (value < -1 || value > 1) {
                throw new ArgumentException("Not valid argument, must be -1 <= value <= 1");
            }
            
            I = AlignIndex(I);
            J = AlignIndex(J);

            Weigths[I, J] = value;
        }
        public int AlignIndex(int I) {
            if (I == 0)
                I = Weigths.GetLength(0) - 1;
            else
                I--;
            return I;
        }
        private double[] Prev_x_weigths_with_tanh(double[] prev_vector) {
            double[] next_vector = new double[Weigths.GetLength(1)];

            if (prev_vector.Length != Weigths.GetLength(0)) {
                throw new Exception(
                    "Vector length must equal matrix row count.");
            }

            for (int i = 0; i < Weigths.GetLength(1); i++) {
                for (int j = 0; j < Weigths.GetLength(0); j++) {
                    next_vector[i] += prev_vector[j] * Weigths[j, i];
                }
            }

            for (int i = 0; i < next_vector.Length; i++) {
                if (next_vector[i] >= 0)
                    next_vector[i] = Math.Tanh(next_vector[i]);
                else
                    next_vector[i] = 0;
            }

            return next_vector;
        }
        private bool Compare_vectors_equality(double[] prev_vector, double[] next_vector, double e) {

            bool are_equal = true;

            for (int i = 0; i < prev_vector.GetLength(0); i++) {
                if (Math.Abs(prev_vector[i] - next_vector[i]) >= e) {
                    are_equal = false;
                    break;
                }
            }

            return are_equal;
        }
        public double Importance_index(double[] start_vector, double e = 0.00001, int maxIterations = 1000000) {

            double[] prev_vector;
            double[] next_vector = start_vector;

            int iteration = 0;
            do {
                prev_vector = (double[])next_vector.Clone();
                next_vector = Prev_x_weigths_with_tanh(prev_vector);
                iteration++;
            } while (!Compare_vectors_equality(prev_vector, next_vector, e)
                     && iteration < maxIterations);

            return next_vector[next_vector.Length - 1];

        }
        public FCM(string concept) {
            Concepts = new string[1];
            Concepts[0] = concept;
            Weigths = new double[1, 1];
            Weigths[0, 0] = 1;
        }
        public FCM(string[] concepts) {
            Concepts = concepts;
            Weigths = new double[Concepts.Length, Concepts.Length];
            for (int i = 0; i < Weigths.GetLength(0); i++) {
                for (int j = 0; j < Weigths.GetLength(0); j++) {
                    if (i == j) {
                        Weigths[i, j] = 1;
                    }
                }
            }
        }



    }
}
