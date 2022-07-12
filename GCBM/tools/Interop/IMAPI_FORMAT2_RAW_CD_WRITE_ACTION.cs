﻿using System.Runtime.InteropServices;

namespace PluginBurnMedia.Interop
{
    public enum IMAPI_FORMAT2_RAW_CD_WRITE_ACTION
    {
        [TypeLibVar(0x40)] IMAPI_FORMAT2_RAW_CD_WRITE_ACTION_UNKNOWN = 0,
        IMAPI_FORMAT2_RAW_CD_WRITE_ACTION_PREPARING = 1,
        IMAPI_FORMAT2_RAW_CD_WRITE_ACTION_WRITING = 2,
        IMAPI_FORMAT2_RAW_CD_WRITE_ACTION_FINISHING = 3
    }
}