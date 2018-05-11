namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class UserGroupService
    {
        private SuperMContext Context;

        public UserGroupService()
        {
            Context = new SuperMContext();
        }

        public dynamic GetUserGroupList()
        {
            UserService userService = new UserService();
            var userGroups = Context.UserGroups.Select(x => new { x.UserGroupId, UserName = x.User.Name, GroupName = x.Group.Name }).ToList();
            return userGroups;
        }

        public UserGroup GetUserGroupById(int userGroupId)
        {
            UserGroup userGroup = Context.UserGroups.FirstOrDefault(x => x.UserGroupId == userGroupId);
            return userGroup;
        }

        public UserGroup GetUserGroupByUserId(int userId)
        {
            UserGroup userGroup = Context.UserGroups.FirstOrDefault(x => x.UserId == userId);
            return userGroup;
        }

        public List<UserGroup> GetUserGroupListByName(int userId)
        {
            var userGroups = Context.UserGroups.Where(x => x.UserId == userId).ToList();
            return userGroups;
        }

        public bool IsUserGroupIdExisted(int userGroupId)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.UserGroups.Count(x => x.UserGroupId == userGroupId) > 0);
            return isNameExisted;
        }

        public void Add(UserGroup userGroup)
        {
            Context.UserGroups.Add(userGroup);
            Context.SaveChanges();
        }

        public void DeleteUserGroupById(int userGroupId)
        {
            UserGroup userGroup = GetUserGroupById(userGroupId);
            Context.UserGroups.Remove(userGroup);
            Context.SaveChanges();
        }

        public void UpdateUserGroupByUserGroup(UserGroup userGroup)
        {
            var UserGroup = GetUserGroupById(userGroup.UserGroupId);
            if (UserGroup != null)
            {
                UserGroup.UserGroupId = userGroup.UserGroupId;
                UserGroup.UserId = userGroup.UserId;
                UserGroup.GroupId = userGroup.GroupId;
            }
            Context.SaveChanges();
        }
    }
}
