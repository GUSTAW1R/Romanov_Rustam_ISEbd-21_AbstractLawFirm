﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLawFirm___ServiceDAL.BindingModel
{
    [DataContract]
    public class BlankBindingModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string BlankName { get; set; }
    }
}
