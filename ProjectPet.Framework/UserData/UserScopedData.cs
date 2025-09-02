using ProjectPet.SharedKernel.ErrorClasses;

namespace ProjectPet.Framework.UserData;

public class UserScopedData
{
    public Guid? UserId { get; set; }

    public List<string>? Permissions { get; set; }

    public List<string>? Roles { get; set; }

    public bool IsSuccess => Error is null;

    public Error? Error { get; private set; }

    public void MakeErrored(Error? error = null)
    {
        if (error is null)
            error = Error.Failure("claim.not.found", "Unknown user!");

        Error = error;
    }
}
