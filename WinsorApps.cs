namespace CS_First_HTTP_Client;

public readonly record struct Login(string email, string password);

public readonly record struct ErrorResponse(string type, string error);

public readonly record struct AuthResponse(string userId, string jwt, DateTime expires, string refreshToken);

public readonly record struct UserInfo(string id, string firstName, string nickname, string lastName, string email);

public readonly record struct StudentInfo(int gradYear, string className, AdvisorInfo advisor);

public readonly struct AdvisorInfo(string id, string firstName, string lastName, string email);

public readonly record struct CycleDay(DateOnly date, string cycleDay);