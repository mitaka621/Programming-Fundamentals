using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            AllTeams group1=new AllTeams();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();
                group1.AddTeam(input[1], input[0]);
            }
            string input2;
            while ((input2=Console.ReadLine())!= "end of assignment")
            {
                string[] commands = input2.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                group1.AddMembertoTeam(commands[0], commands[1]);
            }
            Console.WriteLine(group1.ToString());
        }
        public class Team
        {
            private readonly List<string> members;
            public Team(string teamName, string creator)
            {
                TeamName = teamName;
                Creator = creator;
                members = new List<string>();
            }

            public string TeamName { get;private set; }
            public string Creator { get;private set; }

            public List<string> Members
            => this.members;
            public void AddMember(string member)
            {
                this.members.Add(member);
            }
        }

        public class AllTeams
        {
            private List<Team> teams;

            public AllTeams()
            {
                teams = new List<Team>();
            }

            public void AddTeam(string teamName, string creator)
            {
                if (teams.Any(t => t.TeamName == teamName))
                {

                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                    if (teams.Any(y => y.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(teamName, creator));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            public void AddMembertoTeam(string player, string teamName)
            {
                if (!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(player))|| teams.Any(t => t.Creator==player))
                {
                    Console.WriteLine($"Member {player} cannot join team {teamName}!");
                }
                else
                {
                    teams.First(t => t.TeamName == teamName).AddMember(player);
                    
                }
            }
            
            private List<string> DisbandEmptyTeams()
            {
                List<string> disbandedTeams = new List<string>();
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].Members.Count==0)
                    {
                        disbandedTeams.Add(teams[i].TeamName);
                        teams.RemoveAt(i);
                        i--;
                    }
                }
                disbandedTeams.Sort();
                return disbandedTeams;
            }

            private void SortTeams()
            {
                teams = teams.OrderByDescending(x => x.Members.Count()).ThenBy(x => x.TeamName).ToList();
                
            }

            public override string ToString()
            {
                SortTeams();
                List<string> a=DisbandEmptyTeams();
                string output= string.Empty;
                foreach (Team item in teams)
                {
                    item.Members.Sort();
                    output+=item.TeamName+"\n- "+item.Creator+"\n-- "+string.Join("\n-- ", item.Members)+"\n";
                }
                output += "Teams to disband:" + "\n" + string.Join("\n", a);
                return output;
            }
        }
    }
}
