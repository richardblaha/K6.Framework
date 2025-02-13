namespace K6.Application;

public class NotFoundException(string message) : Exception(message)
{
}