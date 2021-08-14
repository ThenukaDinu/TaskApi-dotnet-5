using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Modals;

namespace TaskApi.Services.Authors
{
    public interface IAuthorRepository
    {
        List<Author> GetAllAuthors();
        Author GetAuthor(int id);
        List<Author> GetAllAuthors(string job, string search);
    }
}
