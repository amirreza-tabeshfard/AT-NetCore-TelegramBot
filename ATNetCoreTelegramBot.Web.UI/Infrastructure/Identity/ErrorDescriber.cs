using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;

namespace ATNetCoreTelegramBot.Web.UI.Infrastructure.Identity;

internal class ErrorDescriber : IdentityErrorDescriber
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ErrorDescriber(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public override IdentityError ConcurrencyFailure()
    {
        return base.ConcurrencyFailure();
    }

    public override IdentityError DuplicateEmail(string email)
    {
        return base.DuplicateEmail(email);
    }

    public override IdentityError DuplicateUserName(string userName)
    {
        return base.DuplicateUserName(userName);
    }

    public override IdentityError InvalidEmail(string email)
    {
        return base.InvalidEmail(email);
    }

    public override IdentityError DuplicateRoleName(string role)
    {
        return base.DuplicateRoleName(role);
    }

    public override IdentityError DefaultError()
    {
        return base.DefaultError();
    }

    public override IdentityError InvalidRoleName(string role)
    {
        return base.InvalidRoleName(role);
    }

    public override IdentityError InvalidToken()
    {
        return base.InvalidToken();
    }

    public override IdentityError InvalidUserName(string userName)
    {
        return base.InvalidUserName(userName);
    }

    public override IdentityError LoginAlreadyAssociated()
    {
        return base.LoginAlreadyAssociated();
    }

    public override IdentityError PasswordMismatch()
    {
        return base.PasswordMismatch();
    }

    public override IdentityError PasswordRequiresDigit()
    {
        return base.PasswordRequiresDigit();
    }

    public override IdentityError PasswordRequiresLower()
    {
        IdentityError identityError = default;
        string Culture = _httpContextAccessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.ToString();

        switch (Culture)
        {
            case Common.Infrastructure.Culture.Farsi_Iran:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresLower),
                        Description = $"گذرواژه ها باید حداقل یک حرف کوچک داشته باشند ('a' - 'z')."
                    };
                }
                break;

            case Common.Infrastructure.Culture.English_UnitedStates:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresLower),
                        Description = $"Passwords must have at least one lowercase('a' - 'z')."
                    };
                }
                break;

            default:
                return base.PasswordRequiresLower();
        }

        return identityError;
    }

    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        IdentityError identityError = default;
        string Culture = _httpContextAccessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.ToString();

        switch (Culture)
        {
            case Common.Infrastructure.Culture.Farsi_Iran:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresNonAlphanumeric),
                        Description = $"گذرواژه ها باید حداقل یک کاراکتر غیر الفبا داشته باشند."
                    };
                }
                break;

            case Common.Infrastructure.Culture.English_UnitedStates:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresNonAlphanumeric),
                        Description = $"Passwords must have at least one non alphanumeric character."
                    };
                }
                break;

            default:
                return base.PasswordRequiresNonAlphanumeric();
        }

        return identityError;
    }

    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
    {
        return base.PasswordRequiresUniqueChars(uniqueChars);
    }

    public override IdentityError PasswordRequiresUpper()
    {
        IdentityError identityError = default;
        string Culture = _httpContextAccessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.ToString();

        switch (Culture)
        {
            case Common.Infrastructure.Culture.Farsi_Iran:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresUpper),
                        Description = $"گذرواژه ها باید حداقل یک حرف بزرگ داشته باشند ('A' - 'Z')."
                    };
                }
                break;

            case Common.Infrastructure.Culture.English_UnitedStates:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(PasswordRequiresUpper),
                        Description = $"Passwords must have at least one uppercase('A' - 'Z')."
                    };
                }
                break;

            default:
                return base.PasswordRequiresUpper();
        }

        return identityError;
    }

    public override IdentityError PasswordTooShort(int length)
    {
        return base.PasswordTooShort(length);
    }

    public override IdentityError RecoveryCodeRedemptionFailed()
    {
        return base.RecoveryCodeRedemptionFailed();
    }

    public override IdentityError UserAlreadyHasPassword()
    {
        return base.UserAlreadyHasPassword();
    }

    public override IdentityError UserAlreadyInRole(string role)
    {
        IdentityError identityError = default;
        string Culture = _httpContextAccessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.ToString();

        switch (Culture)
        {
            case Common.Infrastructure.Culture.Farsi_Iran:
                {
                    identityError = new IdentityError
                    {
                        Code = nameof(UserAlreadyInRole),
                        Description = $"کاربر در مقام {role} می باشد."
                    };
                }
                break;
        }

        return identityError;
        //return base.UserAlreadyInRole(role);
    }

    public override IdentityError UserLockoutNotEnabled()
    {
        return base.UserLockoutNotEnabled();
    }

    public override IdentityError UserNotInRole(string role)
    {
        return base.UserNotInRole(role);
    }
}