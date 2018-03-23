using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules.Dms.DataLayer.Domain.Enums
{
    public enum CustomerType : int {

        /// <summary>
        /// Gerçek
        /// </summary>
        Individual = 1,
        /// <summary>
        /// Tüzel
        /// </summary>
        Corporate=2,
        /// <summary>
        /// Ortak
        /// </summary>
        Joint=3,
        /// <summary>
        /// Reşit olmayan
        /// </summary>
        Minor=4,
        /// <summary>
        /// Adi Ortaklık
        /// </summary>
        CommonPartnership = 5,
        /// <summary>
        /// Vesayete Tabi
        /// </summary>
        SubjectToGuardianship = 6

    }
}
