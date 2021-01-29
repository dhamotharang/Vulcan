using DAL.Vulcan.Mongo.Base.Core.DocClass;
using DAL.Vulcan.Mongo.Base.Core.Repository;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;

namespace DAL.Vulcan.Mongo.Core.DocClass.Ldap
{
    [BsonIgnoreExtraElements]
    public class UserRef: ReferenceObject<LdapUser>
    {
        public string NetworkId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string UserName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public LdapUser AsUser()
        {
            var id = ObjectId.Parse(Id);
            return new RepositoryBase<LdapUser>().AsQueryable().FirstOrDefault(x=>x.Id == id);
        }

        public UserRef()
        {
            
        }

        public UserRef(LdapUser document) : base(document)
        {
            FirstName = document.FirstName;
            LastName = document.LastName;
        }
    }
}