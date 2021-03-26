using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace tv
{
    class ModifyFileName
    {
        public bool ModifyFileNameBool(string srcRelativePath, string desRelativePath)
        {
            srcRelativePath = HttpContext.Current.Server.MapPath(srcRelativePath);
            desRelativePath = HttpContext.Current.Server.MapPath(desRelativePath);
            try
            {
                if (File.Exists(srcRelativePath))
                {
                    FileInfo fi = new FileInfo(srcRelativePath);
                    fi.MoveTo(desRelativePath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
