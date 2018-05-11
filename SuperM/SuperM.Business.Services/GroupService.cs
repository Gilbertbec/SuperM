namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupService
    {
        private SuperMContext Context;

        public GroupService()
        {
            Context = new SuperMContext();
        }

        public List<Group> GetGroupList()
        {
            var groups = Context.Groups.ToList();
            return groups;
        }

        public Group GetGroupById(int groupId)
        {
            Group group = Context.Groups.FirstOrDefault(x => x.GroupId == groupId);
            return group;
        }

        public List<Group> GetGroupListByName(string name)
        {
            var gropus = Context.Groups.Where(x => x.Name.Contains(name)).ToList();
            return gropus;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Groups.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Group group)
        {
            Context.Groups.Add(group);
            Context.SaveChanges();
        }

        public void DeleteGroupById(int groupId)
        {
            Group group = GetGroupById(groupId);
            Context.Groups.Remove(group);
            Context.SaveChanges();
        }

        public void UpdateGroupByGroup(Group group)
        {
            var Group = GetGroupById(group.GroupId);
            if (Group != null)
            {
                Group.GroupId = group.GroupId;
                Group.Name = group.Name;
            }
            Context.SaveChanges();
        }
    }
}
