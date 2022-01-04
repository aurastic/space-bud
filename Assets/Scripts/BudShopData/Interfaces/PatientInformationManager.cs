using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BudShopData
{
    public enum PatientType
    {
        Medical,
        Recreational,
        Scammer,
        Addict,
        Senior
    }
    public enum GenderType
    {
        Female,
        Male,
        Nonbinary
    }
    public interface PatientInformationManager
    {
        string PatientName { get; }
        StrainType FavoriteStrain { get; }
        PatientType PatientType { get; }
        int PatientAge { get; }
        GenderType GenderType { get; }

    }

}








