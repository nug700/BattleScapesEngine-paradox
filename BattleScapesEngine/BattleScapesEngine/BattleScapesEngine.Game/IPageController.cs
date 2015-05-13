﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleScapesEngine
{
    public interface IPageController
    {
        bool BuilderExists(int x, int y, int z);
        bool BuilderGenerated(int x, int y, int z);
        IVoxelBuilder GetBuilder(int x, int y, int z);
        void UpdateChunk(int x, int y, int z);
        void AddBlockType(BaseType _baseType, string _name, int[] _textures);
    }
}
