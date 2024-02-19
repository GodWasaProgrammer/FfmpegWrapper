namespace FfmpegWrapper;

internal class Settings
{
    /// <summary>
    /// Directory where FFmpeg exe is located
    /// </summary>
    private string _FfmpegDir = "path to your ffmpeg";
    public string FfmpegDir { get { return _FfmpegDir; } set { _FfmpegDir = value; } }

    /// <summary>
    /// The Dir where videos are
    /// </summary>
    private string _WorkDir = "YTDL";
    public string workDir { get { return _WorkDir; } set { _WorkDir = value; } }
}
