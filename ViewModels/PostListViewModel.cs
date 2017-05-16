using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SingersWebApi.ViewModels
{
    [DataContract]
    public class PostListViewModel
    {
        [DataMember(Name = "list")]
        public Model.List List { get; set; }
    }
}
