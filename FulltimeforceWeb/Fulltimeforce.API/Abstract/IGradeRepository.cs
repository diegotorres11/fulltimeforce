using Fulltimeforce.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fulltimeforce.API.Abstract
{
    public interface IGradeRepository
    {
        int Add(Grade grade);
    }
}
