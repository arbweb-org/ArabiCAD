using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace p_arabicad
{
    abstract class _c_point : _c_constraint
    {
        public abstract (double g_xcr_, double g_ycr_) g_crd_();
    }
}