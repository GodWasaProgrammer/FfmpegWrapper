﻿using System.Diagnostics;

namespace FfmpegWrapper;

internal class FFmpegHandler
{
    /// <summary>
    /// This runs the process of ffmpeg and feeds it with parameters for file extraction
    /// </summary>
    /// <param name="parameters"></param>
    private static async Task ExecuteFFMPG(string parameters, Settings settings)
    {
        Process processFFMpeg = new();

        processFFMpeg.StartInfo.FileName = settings.FfmpegDir;
        processFFMpeg.StartInfo.WorkingDirectory = settings.workDir;
        processFFMpeg.StartInfo.Arguments = parameters;
        processFFMpeg.StartInfo.UseShellExecute = false;
        processFFMpeg.StartInfo.CreateNoWindow = false;
        processFFMpeg.StartInfo.RedirectStandardOutput = true;

        bool ProcessStarted = processFFMpeg.Start();
        await Task.Run(() => processFFMpeg.WaitForExit());
    }

    /// <summary>
    /// This runs FFMpeg.exe and extracts the files requested based on the CLI input
    /// </summary>
    /// <param name="parameters"></param>
    /// <param name="outPath"></param>
    public static async Task RunFFMPG(Dictionary<string, string> parameters, string outPath, Settings settings)
    {
        var exePars = "";
        foreach (var parameter in parameters)
        {
            exePars += "-" + parameter.Key;
            exePars += " " + parameter.Value + " ";
        }

        exePars += outPath;
        _ = new
        FFmpegHandler();

        await ExecuteFFMPG(exePars, settings);
    }
}