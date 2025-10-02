using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    /*
 * Eğer, nesnenizin immutable (değişmez) olmasını istiyorsanız, class yerine aşağıdaki gibi record tanımlayabilirsiniz:
 */
    public record ProductDto(int Id, string Name, decimal Price, string Category);


    //public record CategoryDto
    //{
    //    public string Name { get; set; }
    //}

}
