using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonn.Communication
{
    [Serializable]
    public enum Operation
    {
        Login,
        Logout,
        CreateMusicGroup,
        CreateSinger,
        CreateScene,
        GetAllMusicGroups,
        GetAllConcerts,
        GetAllSingers,
        GetAllGroups,
        GetAllScenes,
        GetMusicGroupById,
        GetMusicGroupByName,
        GetSingerById,
        GetSingerByName,
        GetSceneById,
        GetSceneByDate,
        UpdateMusicGroup,
        UpdateSinger,
        UpdateScene,
        DeleteSinger,
    }
}
