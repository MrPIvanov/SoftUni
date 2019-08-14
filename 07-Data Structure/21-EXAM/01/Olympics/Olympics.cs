using System;
using System.Collections.Generic;
using System.Linq;

public class Olympics : IOlympics
{
    private Dictionary<int, Competition> competitionsById = new Dictionary<int, Competition>();
    private Dictionary<int, Competitor> playersById = new Dictionary<int, Competitor>();

    public void AddCompetitor(int id, string name)
    {
        if (this.playersById.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        var current = new Competitor(id, name);
        this.playersById.Add(id, current);
    }

    public void AddCompetition(int id, string name, int participantsLimit)
    {
        if (this.competitionsById.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        var current = new Competition(name, id, participantsLimit);
        this.competitionsById.Add(id, current);
    }

    public void Compete(int competitorId, int competitionId)
    {
        if (!this.playersById.ContainsKey(competitorId))
        {
            throw new ArgumentException();
        }

        if (!this.competitionsById.ContainsKey(competitionId))
        {
            throw new ArgumentException();
        }

        var player = this.playersById[competitorId];
        var competition = this.competitionsById[competitionId];

        if (competition.Competitors == null)
        {
            competition.Competitors = new HashSet<Competitor>();
        }

        player.TotalScore += competition.Score;
        competition.Competitors.Add(player);

        //add score ???
        //maybe if he is already in exeption ???
    }

    public void Disqualify(int competitionId, int competitorId)
    {
        if (!this.playersById.ContainsKey(competitorId))
        {
            throw new ArgumentException();
        }

        if (!this.competitionsById.ContainsKey(competitionId))
        {
            throw new ArgumentException();
        }

        var competition = this.competitionsById[competitionId];
        var player = this.playersById[competitorId];

        if (!competition.Competitors.Contains(player))
        {
            throw new ArgumentException();
        }

        player.TotalScore = player.TotalScore - competition.Score;
        competition.Competitors.Remove(player);

    }

    public IEnumerable<Competitor> FindCompetitorsInRange(long min, long max)
    {
        return this.playersById.Values.Where(x => x.TotalScore > min && x.TotalScore <= max).OrderBy(x => x.Id);  //Performance
    }

    public IEnumerable<Competitor> GetByName(string name)
    {
        var result = this.playersById.Values.Where(x => x.Name == name).OrderBy(x => x.Id);  //Performance

        if (result.Count() == 0)
        {
            throw new ArgumentException();
        }
        return result;
    }

    public IEnumerable<Competitor> SearchWithNameLength(int min, int max)
    {
        return this.playersById.Values.Where(x => x.Name.Length >= min && x.Name.Length <= max).OrderBy(x => x.Id);
    }

    public bool Contains(int competitionId, Competitor comp)
    {
        if (!this.competitionsById.ContainsKey(competitionId))
        {
            throw new ArgumentException();
        }

        
        return this.competitionsById[competitionId].Competitors.Contains(comp);
    }

    public int CompetitionsCount()
    {
        return this.competitionsById.Values.Count;
    }

    public int CompetitorsCount()
    {
        return this.playersById.Values.Count;
    }

    public Competition GetCompetition(int id)
    {
        if (!this.competitionsById.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        return this.competitionsById[id];
    }
}