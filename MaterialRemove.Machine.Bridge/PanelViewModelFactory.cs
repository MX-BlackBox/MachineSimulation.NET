using Machine.ViewModels.Interfaces.Factories;
using Machine.ViewModels.Interfaces.MachineElements;
using System;
using System.Collections.Generic;
using System.Text;
using MVMIoc = Machine.ViewModels.Ioc;
using MVMI = Machine.ViewModels.Interfaces;
using MaterialRemove.Interfaces;
using MaterialRemove.Interfaces.Enums;

namespace MaterialRemove.Machine.Bridge
{
    public class PanelViewModelFactory : IPanelElementFactory
    {
        public IPanelElement Create(double centerX, double centerY, double centerZ, double sizeX, double sizeY, double sizeZ)
        {
            var materialRemoveData = MVMIoc.SimpleIoc<IMaterialRemoveData>.GetInstance();

            var panel = new PanelViewModel()
            {
                CenterX = centerX,
                CenterY = centerY,
                CenterZ = centerZ,
                SizeX = sizeX,
                SizeY = sizeY,
                SizeZ = sizeZ,
                NumCells = 16,
                SectionsX100mm = Convert(materialRemoveData.SectionsX100mm),
                FilterMargin = 0.1,
                PanelFragment = materialRemoveData.PanelFragment,
                SectionDivision = Convert(materialRemoveData.SectionDivision),
            };

            panel.Initialize();

            return panel;
        }

        private int Convert(SectionsPer100mm value)
        {
            switch (value)
            {
                case SectionsPer100mm.Per_3:
                    return 3;
                case SectionsPer100mm.Per_4:
                    return 4;
                case SectionsPer100mm.Per_5:
                    return 5;
                case SectionsPer100mm.Per_6:
                    return 6;
                case SectionsPer100mm.Per_8:
                    return 8;
                case SectionsPer100mm.Per_10:
                    return 10;
                case SectionsPer100mm.Per_12:
                    return 12;
                case SectionsPer100mm.Per_15:
                    return 15;
                case SectionsPer100mm.Per_20:
                    return 20;
                default:
                    throw new ArgumentOutOfRangeException($"Value {value} not managed!");
            }
        }

        private static int Convert(SectionDivision value)
        {
            switch (value)
            {
                case SectionDivision.By_5:
                    return 5;
                case SectionDivision.By_8:
                    return 8;
                case SectionDivision.By_10:
                    return 10;
                case SectionDivision.By_12:
                    return 12;
                case SectionDivision.By_15:
                    return 15;
                case SectionDivision.By_20:
                    return 20;
                default:
                    throw new ArgumentOutOfRangeException($"Value {value} not managed!");
            }
        }
    }
}
