using DAL.Vulcan.Mongo.Base.Core.DocClass;
using DAL.Vulcan.Mongo.Core.DocClass.Ldap;

namespace DAL.Vulcan.Mongo.Core.DocClass.Security
{
    public class RoleMember: BaseDocument
    {
        public LdapUser User { get; set; }
        public bool IsRevoked { get; set; } = false;
        public bool IsAdmin { get; set; } = false;


    }
}