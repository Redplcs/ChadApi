namespace Redplcs.ChadApi;

public interface IChadModel
{
	Task<string> GenerateAsync(string prompt, CancellationToken cancellationToken = default);
}
