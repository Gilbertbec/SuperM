namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class PositionService
    {
        private SuperMContext Context;

        public PositionService()
        {
            Context = new SuperMContext();
        }

        public List<Position> GetPositionList()
        {
            var positions = Context.Positions.ToList();
            return positions;
        }

        public Position GetPositionById(int positionId)
        {
            Position position = Context.Positions.FirstOrDefault(x => x.PositionId == positionId);
            return position;
        }

        public List<Position> GetPositionListByName(string name)
        {
            var positions = Context.Positions.Where(x => x.Name.Contains(name)).ToList();
            return positions;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Positions.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Position position)
        {
            Context.Positions.Add(position);
            Context.SaveChanges();
        }

        public void DeletePositionById(int positionId)
        {
            Position position = GetPositionById(positionId);
            Context.Positions.Remove(position);
            Context.SaveChanges();
        }

        public void UpdatePositionByPosition(Position position)
        {
            var Position = GetPositionById(position.PositionId);
            if (Position != null)
            {
                Position.PositionId = position.PositionId;
                Position.Name = position.Name;
            }
            Context.SaveChanges();
        }
    }
}
