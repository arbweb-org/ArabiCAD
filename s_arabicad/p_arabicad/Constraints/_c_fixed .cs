using System;
using System.Collections.Generic;
using System.Text;

namespace p_arabicad.Constraints
{
    class _c_fixed : _c_point
    {
        double r_xcr_;
        double r_ycr_;

        public _c_fixed(double p_xcr_, double p_ycr_)
        {
            r_xcr_ = p_xcr_;
            r_ycr_ = p_ycr_;
        }

        public override (double g_xcr_, double g_ycr_) g_crd_()
        {
            return (r_xcr_, r_ycr_);
        }

    }
}