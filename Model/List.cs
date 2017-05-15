﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SingersWebApi.Model
{
    [DataContract]
    public class List
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "order")]
        public int Order { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "birth_date")]
        public string BirthDate { get; set; }

        [DataMember(Name = "is_alive")]
        public bool IsAlive { get; set; }
    }
}
