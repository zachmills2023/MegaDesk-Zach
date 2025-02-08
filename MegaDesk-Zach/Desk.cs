using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Zach
{
    // Store all of the attributes and data associated with the desk.
    public class Desk
    {

        public int Width                { get; set; }
        public int Depth                { get; set; }
        public int Drawers              { get; set; }
        public DesktopMaterial Material { get; set; }


        public const int MIN_WIDTH    =   24;
        public const int MAX_WIDTH    =   96;

        public const int MIN_DEPTH    =   12;
        public const int MAX_DEPTH    =   48;

        public const int MIN_DRAWERS  =    0;
        public const int MAX_DRAWERS  =    7;

        public Desk(int width, int depth, int drawers, DesktopMaterial material) 
        { 
            this.Width      =      width;
            this.Depth      =      depth;
            this.Drawers    =    drawers;
            this.Material   =   material;
        }

        public int GetArea()
        {
            return Width * Depth;
        }

        public int GetMaterialCost()
        {
            return (int)Material; 
        }

    }

    public enum DesktopMaterial 
    { 
        laminate   =    100,
        oak        =    200,
        rosewood   =    300,
        vernir     =    125,
        pine       =     50 
    }
}
