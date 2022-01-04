using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace BudShopData
{
    public class PatientInformationBase : MonoBehaviour, PatientInformationManager
    {
        public string patientName;
        public StrainType favoriteStrain;
        public PatientType patientType;
        public string[] femaleNames = new string[6] { "Emma", "Jessica", "Amanda", "Flora", "Mary", "Melissa" };
        public string[] genderNeutralNames = new string[5] { "Zo", "Alex", "Sam", "Tobey", "Pleak" };
        public string[] maleNames = new string[5] { "Jacob", "Dan", "William", "Nick", "Maxwell" };
        public int age;
        public GenderType gender;

        public string PatientName => patientName;

        public StrainType FavoriteStrain => favoriteStrain;

        public PatientType PatientType => patientType;

        public int PatientAge => age;

        public GenderType GenderType => gender;

        void OnEnable()
        {

            SetGender();
            SetName();
            SetAge();
            SetFavStrainType();
            SetPatientType();

        }

        void SetGender()
        {
            var values = System.Enum.GetValues(typeof(GenderType));
            gender = (GenderType)(Random.Range(0, values.Length));

        }

        void SetName()
        {
            if (gender == GenderType.Female)
            {
                patientName = femaleNames[Random.Range(0, femaleNames.Length)];
            }
            if (gender == GenderType.Male)
            {
                patientName = maleNames[Random.Range(0, maleNames.Length)];
            }
            if (gender == GenderType.Nonbinary)
            {
                patientName = genderNeutralNames[Random.Range(0, genderNeutralNames.Length)];
            }
        }
        void SetAge()
        {
            age = Random.Range(18, 69);
        }
        void SetFavStrainType()
        {
            var values = System.Enum.GetValues(typeof(StrainType));
            favoriteStrain = (StrainType)(Random.Range(0, values.Length));

        }
        void SetPatientType()
        {
            var values = System.Enum.GetValues(typeof(PatientType));

            if (age > 60)
            {
                patientType = PatientType.Senior;
            }
            else
            {
                patientType = (PatientType)(Random.Range(0, values.Length - 1));
            }


        }
    }
}

