﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    [Serializable]
    public class VratiOceneOdgovor
    {
        public OcenaFilma OcenaFilma { get; set; }
        public List<OcenaUloge> OceneUloga { get; set; }
    }
}
