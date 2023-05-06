using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Helpers
{
    public class CustomErrorLanguage:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description="Qaqi zəhmət döörsə paroluna rəqəm də daxil elə"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code=nameof(PasswordTooShort),
                Description= $"Qaqi parolunun uzunluğu minimum {length} xarakter olmalıdı"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "Qaqi zəhmət döörsə paroluna kiçik hərflər də daxil elə"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code=nameof(PasswordRequiresUpper),
                Description= "Qaqi zəhmət döörsə paroluna böyük hərflər də daxil elə"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code=nameof(PasswordRequiresNonAlphanumeric),
                Description= "Qaqi  zəhmət döörsə paroluna simvol da daxil elə"
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code=nameof(DuplicateEmail),
                Description="Qaqi bu email istifadə olunubçsən özvə başqa bir eamil tap"
            };
        }
    }
}
