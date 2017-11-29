using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // dictionaries for data store
        Dictionary<string, int> teamScore = new Dictionary<string, int>();
        Dictionary<string, int> teamGoal = new Dictionary<string, int>();

        string key = Console.ReadLine();
        var input = Console.ReadLine();
        int win = 3;
        int lose = 0;
        int draw = 1;
        while (!input.Equals("final"))
        {
            var inputSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // getting team name
            var teamA = GetTeamName(inputSplit[0], key);
            var teamB = GetTeamName(inputSplit[1], key);
            // reversing name of the team
            var firstTeam = ReversingName(teamA).ToUpper();
            var secondTeam = ReversingName(teamB).ToUpper();
            // checking the result 
            var score = inputSplit[2].Split(':');
            var firstTeamScore = int.Parse(score[0]);
            var secondTeamScore = int.Parse(score[1]);

            if (firstTeamScore > secondTeamScore)
            {
                AddingScoreToTeam(teamScore, firstTeam, win);
                AddingScoreToTeam(teamScore, secondTeam, lose);
            }
            if (secondTeamScore > firstTeamScore)
            {
                AddingScoreToTeam(teamScore, secondTeam, win);
                AddingScoreToTeam(teamScore, firstTeam, lose);
            }
            if (firstTeamScore == secondTeamScore)
            {
                AddingScoreToTeam(teamScore, firstTeam, draw);
                AddingScoreToTeam(teamScore, secondTeam, draw);
            }
            //Adding goals to teams 
            AddingGoalsToTeam(teamGoal, firstTeam, firstTeamScore);
            AddingGoalsToTeam(teamGoal, secondTeam, secondTeamScore);
            input = Console.ReadLine();
        }
        // PRINTING TEAM STANDING
        Console.WriteLine("League standings:");
        int count = 1;
        foreach (var team in teamScore.OrderByDescending(t => t.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{count}. {team.Key} {team.Value}");
            count++;
        }
        Console.WriteLine("Top 3 scored goals:");       
        for (int i = 0; i < 3; i++)
        {
            var item = teamGoal.OrderByDescending(x => x.Value).ThenBy(t => t.Key).ElementAt(i);
            Console.WriteLine($"- {item.Key} -> {item.Value}");
        }
    }

    private static void AddingGoalsToTeam(Dictionary<string, int> teamGoal, string team, int goals)
    {
        if (!teamGoal.ContainsKey(team))
        {
            teamGoal.Add(team, 0);
        }
        teamGoal[team] += goals;
    }

    private static void AddingScoreToTeam(Dictionary<string, int> teamScore, string team, int score)
    {
        if (!teamScore.ContainsKey(team))
        {
            teamScore.Add(team, 0);
        }
        teamScore[team] += score;
    }

    private static string ReversingName(string teamA)
    {
        char[] team = teamA.ToCharArray();
        Array.Reverse(team);
        return new string(team);
    }

    public static string GetTeamName(string input, string key)
    {
        var startIndex = input.IndexOf(key) + key.Length;
        var restOftheString = input.LastIndexOf(key);
        return input.Substring(startIndex, restOftheString - startIndex);
    }
}

