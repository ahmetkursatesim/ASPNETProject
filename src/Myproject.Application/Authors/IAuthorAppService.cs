using Abp.Application.Services;
using Myproject.Authors.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors
{
    public interface IAuthorAppService:IApplicationService
    {
        IEnumerable<GetAuthorOutput> ListAll();
        Task Create(CreateAuthorInput input);
        void Update(UpdateAuthorInput input);
        void Delete(DeleteAuthorInput input);

        GetAuthorOutput GetBookByID(GetAuthorInput input);
    }
}
