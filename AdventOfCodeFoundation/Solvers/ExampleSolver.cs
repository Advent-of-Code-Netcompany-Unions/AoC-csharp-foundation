﻿using AdventOfCodeFoundation.IO;
using UnionsAoCFoundation.Plumbing;

namespace UnionsAoCFoundation.Solvers
{
    [SolvesChallenge("2022-11-01")]
    public class ExampleSolver : ISolver
    {
        public Task<string> SolvePartOne(Input _)
        {
            return Task.FromResult("Hello, ");            
        }

        public async Task<string> SolvePartTwo(Input _)
        {
            return await Task.Run(() => "World!");
        }
    }
}
