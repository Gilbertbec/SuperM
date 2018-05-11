namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class PermissionService
    {
        private SuperMContext Context;

        public PermissionService()
        {
            Context = new SuperMContext();
        }

        public dynamic GetPermissionList()
        {
            var permissions = Context.Permissions.Select(x => new { x.PermissionId, x.Name, GroupName = x.Group.Name, x.ModelName, x.ControlName }).ToList();
            return permissions;
        }

        public Permission GetPermissionById(int permissionId)
        {
            var permission = Context.Permissions.FirstOrDefault(x => x.PermissionId == permissionId);
            return permission;
        }

        public dynamic GetPermissionByGroupId_Model(int groupId, string modelName)
        {
            var permission = Context.Permissions.Where(x => x.GroupId == groupId && x.ModelName == modelName);
            return permission;
        }

        public List<Permission> GetPermissionListByName(string name)
        {
            var permissions = Context.Permissions.Where(x => x.Name.Contains(name)).ToList();
            return permissions;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Permissions.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Permission permission)
        {
            Context.Permissions.Add(permission);
            Context.SaveChanges();
        }

        public void DeletePermissionById(int permissionId)
        {
            Permission permission = GetPermissionById(permissionId);
            Context.Permissions.Remove(permission);
            Context.SaveChanges();
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
            Context.SaveChanges();
        }
    }
}
