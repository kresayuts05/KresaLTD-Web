using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KresaLTD.Infrastructure.Data.Constants
{
    public static class ModelConstraints
    {
        public static class UserConstants
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int CityMaxLength = 169;
            public const int CityMinLength = 1;

            public const int CountryMaxLength = 56;
            public const int CountryMinLength = 4;

            public const int EmailMaxLength = 50;
            public const int EmailMinLength = 10;
        }
        public static class CategoryConstants
        {
            public const int NameMaxLength = 18;
            public const int NameMinLength = 4;
        }
        public static class ProjectConstants
        {
            public const int DescriptionMaxLength = 2000;
            public const int DescriptionMinLength = 50;

            public const int TitleMaxLength = 100;
            public const int TitleMinLength = 5;

            public const int ShortContentMaxLength = 100;
            public const int ShortContentMinLength = 10;
        }
        public static class ReviewConstants
        {
            public const int FullUserNameMaxLength = 110;
            public const int FullUserNameMinLength = 5;

            public const string RatingMaxValue = "5";
            public const string RatingMinValue = "0";

            public const int DescriptionMaxLength = 1500;
            public const int DescriptionMinLength = 20;
        }
    }
}
