﻿using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    internal interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
