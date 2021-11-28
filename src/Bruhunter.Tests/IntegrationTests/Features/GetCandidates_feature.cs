﻿using Bruhunter.Tests.IntegrationTests;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Feautures
{
    public partial class GetCandidates_feature : FeatureFixtureBase
    {
        private int candidatesCountMustBeAdded = 2;

        [Scenario]
        public async Task Candidates_should_be_received_from_db()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_candidate_in_database(GiveMe.Candidate().Please()),
                    _ => Given_candidate_in_database(GiveMe.Candidate().Please()),
                    _ => When_receive_candidates(),
                    _ => Then_received_candidates_count_should_be(candidatesCountMustBeAdded))
                .RunAsync();
        }
    }
}
