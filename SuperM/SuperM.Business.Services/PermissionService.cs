
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class PermissionService
	{
		private SuperMContext _context;

		public PermissionService()
		{
			_context = new SuperMContext();
		}

		public dynamic GetPermissionList()
		{
			var permissions = _context.Permissions.Select( x => new { x.PermissionId, x.Name, GroupName = x.Group.Name, x.ModelName, x.ControlName}).ToList();
			return permissions;
		}

		public Permission GetPermissionById(int permissionId)
		{
			var permission = _context.Permissions.FirstOrDefault(x => x.PermissionId == permissionId);
			return permission;
		}

		public dynamic GetPermissionByGroupId_Model(int groupId, string modelName)
		{
			var permission = _context.Permissions.Where(x => x.GroupId == groupId && x.ModelName == modelName);
			return permission;
		}

		public List<Permission> GetPermissionListByName(string name)
		{
			var permissions = _context.Permissions.Where(x => x.Name.Contains(name)).ToList();
			return permissions;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.Permissions.Count(x => x.Name == name) > 0);
			return isNameExisted;
		}

		public void Add(Permission permission)
		{
			_context.Permissions.Add(permission);
			_context.SaveChanges();
		}

		public void DeletePermissionById(int permissionId)
		{
			Permission permission = GetPermissionById(permissionId);
			_context.Permissions.Remove(permission);
			_context.SaveChanges();
		}

		public void UpdatePermissionByPermission(Permission permission)
		{
			var Permission = GetPermissionById(permission.PermissionId);
			if (Permission != null)
			{
				Permission.PermissionId = permission.PermissionId;
				Permission.Name = permission.Name;
				Permission.GroupId = permission.GroupId;
				Permission.ModelName = permission.ModelName;
				Permission.ControlName = permission.ControlName;
			}
			_context.SaveChanges();
		}
	}
}
