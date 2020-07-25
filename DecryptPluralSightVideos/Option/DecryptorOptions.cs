namespace DecryptPluralSightVideos.Option
{
    public class DecryptorOptions
    {
        public bool UseDatabase { get; set; } = true;
        public bool UseOutputFolder { get; set; } = true;
        public bool RemoveFolderAfterDecryption { get; set; }
        public bool UsageCommand { get; set; }
        public bool CreateTranscript { get; set; } = true;
        public string InputPath { get; set; } = @"C:\Users\JassarAl-akhras\AppData\Local\Pluralsight\courses";
        public string DatabasePath { get; set; } = @"C:\Users\JassarAl-akhras\AppData\Local\Pluralsight\pluralsight.db";
        public string OutputPath { get; set; } = @"F:\Courses premium\testtt";

    }
}
