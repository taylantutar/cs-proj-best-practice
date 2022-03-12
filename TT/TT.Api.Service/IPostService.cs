using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Api.Data.Model;

namespace TT.Api.Service
{
    public interface IPostService
    {
        PostDto GetById(int id);
    }
}
