using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT.ApplicationService.GPTProduct
{
    public class GPTProductResponseModel
    {
        public List<string> GPTContent { get; set; }
        public bool Success { get; set; }
    }
}
