using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface IGearShiftBoxService
    {
        void AddGearShiftBox();
        GearShiftBoxDTO GetGearShiftBoxId(int? id);
        IEnumerable<GearShiftBoxDTO> GetGearShiftBoxALL();
        void Dispose();
    }
}
