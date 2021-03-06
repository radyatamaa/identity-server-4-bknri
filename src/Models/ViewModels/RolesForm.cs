using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Models.ViewModels
{
    public class RolesForm
    {
        public RolesForm(Roles roles)
        {
            if (roles != null)
            {
                this.Id = roles.Id.ToString();
                this.RoleName = roles.RoleName;
                this.RoleType = roles.RoleType;
                this.Description = roles.Description;
            }
        }
        public string Id { get; set; }
        public string RoleName { get; set; }
        public int? RoleType { get; set; }
        public string Description { get; set; }
        public List<int> PermissionId { get; set; }
    }
}
