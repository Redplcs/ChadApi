namespace Redplcs.ChadApi;

public class ChadClient : IDisposable, IChadClient
{
	private readonly HttpClient _httpClient;
	private bool _disposed;

	public ChadClient()
	{
		_httpClient = new HttpClient();
	}

	public IChadGpt4oMiniModel Gpt4oMini { get; }
	public IChadGpt4oModel Gpt4o { get; }
	public IChadClaude3HaikuModel Claude3Haiku { get; }
	public IChadClaude3OpusModel Claude3Opus { get; }
	public IChadClaude3p5SonnetModel Claude3p5Sonnet { get; }

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			if (disposing)
			{
				_httpClient.Dispose();
			}

			_disposed = true;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
