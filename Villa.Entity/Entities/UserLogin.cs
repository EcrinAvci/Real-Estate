using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace Villa.Entity.Entities
{
    public class UserLogin: IdentityUserLogin<ObjectId>
    {
    }
}
