
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class PositionService
	{
		private SuperMContext _context;

		public PositionService()
		{
			_context = new SuperMContext();
		}

		public List<Position> GetPositionList()
		{
			var positions = _context.Positions.ToList();
			return positions;
		}

		public Position GetPositionById(int positionId)
		{
			Position position = _context.Positions.FirstOrDefault(x => x.PositionId == positionId);
			return position;
		}

		public List<Position> GetPositionListByName(string name)
		{
			var positions = _context.Positions.Where(x => x.Name.Contains(name)).ToList();
			return positions;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.Positions.Count(x => x.Name == name) > 0);
			return isNameExisted;
		}

		public void Add(Position position)
		{
			_context.Positions.Add(position);
			_context.SaveChanges();
		}

		public void DeletePositionById(int positionId)
		{
			Position position = GetPositionById(positionId);
			_context.Positions.Remove(position);
			_context.SaveChanges();
		}

		public void UpdatePositionByPosition(Position position)
		{
			var Position = GetPositionById(position.PositionId);
			if (Position != null)
			{
				Position.PositionId = position.PositionId;
				Position.Name = position.Name;
			}
			_context.SaveChanges();
		}
	}
}
