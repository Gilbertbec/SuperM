
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class UserGroupService
	{
		private SuperMContext _context;

		public UserGroupService()
		{
			_context = new SuperMContext();
		}

		public dynamic GetUserGroupList()
		{
			UserService userService = new UserService();
			var userGroups = _context.UserGroups.Select(x => new { x.UserGroupId, UserName = x.User.Name, GroupName = x.Group.Name}).ToList();
			return userGroups;
		}

		public UserGroup GetUserGroupById(int userGroupId)
		{
			UserGroup userGroup = _context.UserGroups.FirstOrDefault(x => x.UserGroupId == userGroupId);
			return userGroup;
		}

		public UserGroup GetUserGroupByUserId(int userId)
		{
			UserGroup userGroup = _context.UserGroups.FirstOrDefault(x => x.UserId == userId);
			return userGroup;
		}

		public List<UserGroup> GetUserGroupListByName(int userId)
		{
			var userGroups = _context.UserGroups.Where(x => x.UserId == userId).ToList();
			return userGroups;
		}

		public bool IsUserGroupIdExisted(int userGroupId)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.UserGroups.Count(x => x.UserGroupId == userGroupId) > 0);
			return isNameExisted;
		}

		public void Add(UserGroup userGroup)
		{
			_context.UserGroups.Add(userGroup);
			_context.SaveChanges();
		}

		public void DeleteUserGroupById(int userGroupId)
		{
			UserGroup userGroup = GetUserGroupById(userGroupId);
			_context.UserGroups.Remove(userGroup);
			_context.SaveChanges();
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
			_context.SaveChanges();
		}
	}
}
