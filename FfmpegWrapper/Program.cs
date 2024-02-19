namespace FfmpegWrapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example video path
            string pathToVideo = "Analyst： Ivanka Trump isn't a 'secondary player' in fraud trial [pW_UfaPjo6s].webm";
            // example use
            var parameters = new Dictionary<string, string>();

            string extractedfilename = Path.GetFileName(pathToVideo);

            // example parameters
            parameters["i"] = $@"""{extractedfilename}""";
            parameters["vf"] = "select='gt(scene,0.3)',select=key";
            parameters["vsync"] = "vfr";
        }
    }
}
