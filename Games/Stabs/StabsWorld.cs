using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Games.Stabs
{
    public class FloarFight
    {
        protected List<PointFight> points;
    }
    public class WayFight
    {
        protected PointFight _where;
        public void SendUnit(Unit unit)
        {

        }
    }
    public class PointFight
    {

        protected List<Unit> units;
        protected List<WayFight> ways;
        public Unit? FindSimilarUnit(Unit which)
        {
            return units.Find(cheakTarget => cheakTarget.IsSimilar(which) == true);
        }
        public void AddUnit(Unit addedUnit)
        {
            Unit similar = FindSimilarUnit(addedUnit);
            if (similar == null)
            {
                units.Add(addedUnit);
                return;
            }
            similar.count += addedUnit.count;
        }
        public void RemoveUnit(Unit removableObject)
        {

        }
    }
    public class Unit
    {
        protected int _count; public int count { get { return _count; } set { _count = value; } }
        protected Team _team; public Team team { get { return _team; } }
        public bool IsSimilar(Unit unit)
        {
            return this.team == unit.team;
        }
    }
    sealed public class Team
    {
        public Team(string name)
        {
            this._name = name;
        }
        private string _name; public string name
        { get { return _name; } protected set { _name = value; } }
    }
}