﻿using System.Collections.Generic;
using WPL.Application.Models;

namespace WPL.Application.Services
{
    public interface IPlataformaAppService
    {
        IEnumerable<PlataformaModel> GetAll();
    }
}
