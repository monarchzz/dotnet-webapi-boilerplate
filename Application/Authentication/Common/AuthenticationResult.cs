using Domain.Entities;

namespace Application.Authentication.Common;

public record AuthenticationResult(User User, string Token, string RefreshToken);