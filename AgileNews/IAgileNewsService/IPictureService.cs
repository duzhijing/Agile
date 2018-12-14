using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public interface IPictureService
    {
        int PictureAdd(Picture picture);
        List<Picture> GetPictures();
        int PictureDelete(int PictureID);
        int PictureUpdate(Picture picture);
    }
}
