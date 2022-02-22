//Copyright © 2022 Alex Reid (R.M.P.)

//This file is part of Space Bud.

//Space Bud is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License,
//or (at your option) any later version.

//Space Bud is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public
//License along with Space Bud. If not, see <https://www.gnu.org/licenses/>.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceBudData
{
    public class PatientInformationBase : MonoBehaviour, IHavePatientInformation
    {
        public string patientName;  //is there a way to make these both private and accessible by only what's needed?
        public StrainType favoriteStrain;
        public PatientType patientType;
        public string[] femaleNames = new string[6] { "Emma", "Jessica", "Amanda", "Flora", "Mary", "Melissa" };
        public string[] genderNeutralNames = new string[5] { "Zo", "Alex", "Sam", "Tobey", "Pleak" };
        public string[] maleNames = new string[5] { "Jacob", "Dan", "William", "Nick", "Maxwell" };
        public int age;
        public GenderType gender;
        public SpeciesType species;
        public int currentPlaceInLine;



        public string PatientName => patientName;

        public StrainType FavoriteStrain => favoriteStrain;

        public PatientType PatientType => patientType;

        public int PatientAge => age;

        public GenderType GenderType => gender;
        public SpeciesType SpeciesType => species;
        //public int CurrentPlaceInLine => currentPlaceInLine;

        void OnEnable()
        {
            SetGender();
            SetName();
            SetAge();
            SetFavStrainType();
            SetPatientType();
            SetSpeciesType();
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
                patientType = (PatientType)(Random.Range(0, values.Length - 1));  //this needs to be fixed, senior might not be last on the patient types list.
            }
        }
        void SetSpeciesType()
        {
            species = SpeciesType.Florb;
        }
    }
}

