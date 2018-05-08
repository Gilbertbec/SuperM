namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupService
    {
        private SuperMContext _context;

        public GroupService()
        {
            _context = new SuperMContext();
        }

        public List<Group> GetGroupList()
        {
            var groups = _context.Groups.ToList();
            return groups;
        }

        public Group GetGroupById(int groupId)
        {
            Group group = _context.Groups.FirstOrDefault(x => x.GroupId == groupId);
            return group;
        }

        public List<Group> GetGroupListByName(string name)
        {
            var gropus = _context.Groups.Where(x => x.Name.Contains(name)).ToList();
            return gropus;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.Groups.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Group group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();
        }

        public void DeleteGroupById(int groupId)
        {
            Group group = GetGroupById(groupId);
            _context.Groups.Remove(group);
            _context.SaveChanges();
        }

        public void UpdateGroupByGroup(Group group)
        {
            var Group = GetGroupById(group.GroupId);
            if (Group != null)
            {
                Group.GroupId = group.GroupId;
                Group.Name = group.Name;
            }
            _context.SaveChanges();
        }
    }
}
