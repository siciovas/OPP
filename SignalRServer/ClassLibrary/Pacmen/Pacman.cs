﻿using ClassLibrary.Strategies;

namespace ClassLibrary.Pacmen
{
    public class Pacman
    {
        public int PacmanTop { get; set; }
        public int PacmanLeft { get; set; }
        public int Speed { get; set; }
        public int Score { get; set; }

        private Algorithm algorithm;

        public Algorithm GetAlgorithm()
        {
            return algorithm;
        }

        public void SetAlgorithm(Algorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public Pacman() 
        {
            Speed = 8;
            Score = 0;
        }

        public void Action(ref Pacman pacman)
        {
            algorithm.BehaveDifferently(ref pacman);
        }
    }
}