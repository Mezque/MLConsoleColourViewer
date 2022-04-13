using MelonLoader;

namespace ColourViewer
{
    public class ColourViewer : MelonMod
    {
        public override void OnApplicationStart()
        {
            LoggerInstance.Msg("--------------------------------------------------------------------------------");
            LoggerInstance.Msg("About to trolly log all text modifiers to the console!" +
                "\n\x1b[37mHere is some \x1b[0m Normal Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[1m Bold Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[2m Dim Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[4m Underscored Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[5m Blink Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[7m Reverse Text\x1b[0m" +
                "\n\x1b[37mHere is some \x1b[8m Hidden Text\x1b[0m (hidden text lol)" +
                "\n\x1b[37mHere is some \x1b[9m Strike Out Text\x1b[0m");
            LoggerInstance.Msg("--------------------------------------------------------------------------------");
            LoggerInstance.Msg("About to trolly log all 8 bit colours to the console!\n" +
                "\n\x1b[37mHere is some \x1b[30m Black Text \x1b[37(its black text,  but it seems to take whatever background colour you have set for some reason)" +
                "\n\x1b[37mHere is some \x1b[31m Red Text" +
                "\n\x1b[37mHere is some \x1b[32m Green Text" +
                "\n\x1b[37mHere is some \x1b[33m Yellow Text" +
                "\n\x1b[37mHere is some \x1b[34m Blue Text" +
                "\n\x1b[37mHere is some \x1b[35m Magenta Text" +
                "\n\x1b[37mHere is some \x1b[36m Cyan Text" +
                "\n\x1b[37mHere is some \x1b[37m White Text (what did you expect white to look like lol");
            LoggerInstance.Msg("--------------------------------------------------------------------------------");
            LoggerInstance.Msg("About to trolly log all 256 Colors  to the console!" +
                "\n\x1B[38;5;1m Color 1,   \x1B[38;5;2m Color 2,   \x1B[38;5;3m Color 3,   \x1B[38;5;4m Color 4,   \x1B[38;5;5m Color 5,   \x1B[38;5;6m Color 6,   \x1B[38;5;7m Color 7,   \x1B[38;5;8m Color 8,   \x1B[38;5;9m Color 9,   \x1B[38;5;10m Color 10," +
                "\n\x1B[38;5;11m Color 11,  \x1B[38;5;12m Color 12,  \x1B[38;5;13m Color 13,  \x1B[38;5;14m Color 14,  \x1B[38;5;15m Color 15,  \x1B[38;5;16m Color 16,  \x1B[38;5;17m Color 17,  \x1B[38;5;18m Color 18,  \x1B[38;5;19m Color 19,  \x1B[38;5;20m Color 20," +
                "\n\x1B[38;5;21m Color 21,  \x1B[38;5;22m Color 22,  \x1B[38;5;23m Color 23,  \x1B[38;5;24m Color 24,  \x1B[38;5;25m Color 25,  \x1B[38;5;26m Color 26,  \x1B[38;5;27m Color 27,  \x1B[38;5;28m Color 28,  \x1B[38;5;29m Color 29,  \x1B[38;5;30m Color 30," +
                "\n\x1B[38;5;31m Color 31,  \x1B[38;5;32m Color 32,  \x1B[38;5;33m Color 33,  \x1B[38;5;34m Color 34,  \x1B[38;5;35m Color 35,  \x1B[38;5;36m Color 36,  \x1B[38;5;37m Color 37,  \x1B[38;5;38m Color 38,  \x1B[38;5;39m Color 39,  \x1B[38;5;40m Color 40," +
                "\n\x1B[38;5;41m Color 41,  \x1B[38;5;42m Color 42,  \x1B[38;5;43m Color 43,  \x1B[38;5;44m Color 44,  \x1B[38;5;45m Color 45,  \x1B[38;5;46m Color 46,  \x1B[38;5;47m Color 47,  \x1B[38;5;48m Color 48,  \x1B[38;5;49m Color 49,  \x1B[38;5;50m Color 50," +
                "\n\x1B[38;5;51m Color 51,  \x1B[38;5;52m Color 52,  \x1B[38;5;53m Color 53,  \x1B[38;5;54m Color 54,  \x1B[38;5;55m Color 55,  \x1B[38;5;56m Color 56,  \x1B[38;5;57m Color 57,  \x1B[38;5;58m Color 58,  \x1B[38;5;59m Color 59,  \x1B[38;5;60m Color 60," +
                "\n\x1B[38;5;61m Color 61,  \x1B[38;5;62m Color 62,  \x1B[38;5;63m Color 63,  \x1B[38;5;64m Color 64,  \x1B[38;5;65m Color 65,  \x1B[38;5;66m Color 66,  \x1B[38;5;67m Color 67,  \x1B[38;5;68m Color 68,  \x1B[38;5;69m Color 69,  \x1B[38;5;70m Color 70," +
                "\n\x1B[38;5;71m Color 71,  \x1B[38;5;72m Color 72,  \x1B[38;5;73m Color 73,  \x1B[38;5;74m Color 74,  \x1B[38;5;75m Color 75,  \x1B[38;5;76m Color 76,  \x1B[38;5;77m Color 77,  \x1B[38;5;78m Color 78,  \x1B[38;5;79m Color 79,  \x1B[38;5;80m Color 80," +
                "\n\x1B[38;5;81m Color 81,  \x1B[38;5;82m Color 82,  \x1B[38;5;83m Color 83,  \x1B[38;5;84m Color 84,  \x1B[38;5;85m Color 85,  \x1B[38;5;86m Color 86,  \x1B[38;5;87m Color 87,  \x1B[38;5;88m Color 88,  \x1B[38;5;89m Color 89,  \x1B[38;5;90m Color 90," +
                "\n\x1B[38;5;91m Color 91,  \x1B[38;5;92m Color 92,  \x1B[38;5;93m Color 93,  \x1B[38;5;94m Color 94,  \x1B[38;5;95m Color 95,  \x1B[38;5;96m Color 96,  \x1B[38;5;97m Color 97,  \x1B[38;5;98m Color 98,  \x1B[38;5;99m Color 99,  \x1B[38;5;100m Color 100," +
                "\n\x1B[38;5;111m Color 111, \x1B[38;5;112m Color 112, \x1B[38;5;113m Color 113, \x1B[38;5;114m Color 114, \x1B[38;5;115m Color 115, \x1B[38;5;116m Color 116, \x1B[38;5;117m Color 117, \x1B[38;5;118m Color 118, \x1B[38;5;119m Color 119, \x1B[38;5;120m Color 120," +
                "\n\x1B[38;5;121m Color 121, \x1B[38;5;122m Color 122, \x1B[38;5;123m Color 123, \x1B[38;5;124m Color 124, \x1B[38;5;125m Color 125, \x1B[38;5;126m Color 126, \x1B[38;5;127m Color 127, \x1B[38;5;128m Color 128, \x1B[38;5;129m Color 129, \x1B[38;5;130m Color 130," +
                "\n\x1B[38;5;131m Color 131, \x1B[38;5;132m Color 132, \x1B[38;5;133m Color 133, \x1B[38;5;134m Color 134, \x1B[38;5;135m Color 135, \x1B[38;5;136m Color 136, \x1B[38;5;137m Color 137, \x1B[38;5;138m Color 138, \x1B[38;5;139m Color 139, \x1B[38;5;140m Color 140," +
                "\n\x1B[38;5;141m Color 141, \x1B[38;5;142m Color 142, \x1B[38;5;143m Color 143, \x1B[38;5;144m Color 144, \x1B[38;5;145m Color 145, \x1B[38;5;146m Color 146, \x1B[38;5;147m Color 147, \x1B[38;5;148m Color 148, \x1B[38;5;149m Color 149, \x1B[38;5;150m Color 150," +
                "\n\x1B[38;5;161m Color 161, \x1B[38;5;162m Color 162, \x1B[38;5;163m Color 163, \x1B[38;5;164m Color 164, \x1B[38;5;165m Color 165, \x1B[38;5;166m Color 166, \x1B[38;5;167m Color 167, \x1B[38;5;168m Color 168, \x1B[38;5;169m Color 169, \x1B[38;5;170m Color 170," +
                "\n\x1B[38;5;171m Color 171, \x1B[38;5;172m Color 172, \x1B[38;5;173m Color 173, \x1B[38;5;174m Color 174, \x1B[38;5;175m Color 175, \x1B[38;5;176m Color 176, \x1B[38;5;177m Color 177, \x1B[38;5;178m Color 178, \x1B[38;5;179m Color 179, \x1B[38;5;180m Color 180," +
                "\n\x1B[38;5;181m Color 181, \x1B[38;5;182m Color 182, \x1B[38;5;183m Color 183, \x1B[38;5;184m Color 184, \x1B[38;5;185m Color 185, \x1B[38;5;186m Color 186, \x1B[38;5;187m Color 187, \x1B[38;5;188m Color 188, \x1B[38;5;189m Color 189, \x1B[38;5;190m Color 190," +
                "\n\x1B[38;5;191m Color 191, \x1B[38;5;192m Color 192, \x1B[38;5;193m Color 193, \x1B[38;5;194m Color 194, \x1B[38;5;195m Color 195, \x1B[38;5;196m Color 196, \x1B[38;5;197m Color 197, \x1B[38;5;198m Color 198, \x1B[38;5;199m Color 199, \x1B[38;5;200m Color 200," +
                "\n\x1B[38;5;211m Color 211, \x1B[38;5;212m Color 212, \x1B[38;5;213m Color 213, \x1B[38;5;214m Color 214, \x1B[38;5;215m Color 215, \x1B[38;5;216m Color 216, \x1B[38;5;217m Color 217, \x1B[38;5;218m Color 218, \x1B[38;5;219m Color 219, \x1B[38;5;220m Color 220," +
                "\n\x1B[38;5;221m Color 221, \x1B[38;5;222m Color 222, \x1B[38;5;223m Color 223, \x1B[38;5;224m Color 224, \x1B[38;5;225m Color 225, \x1B[38;5;226m Color 226, \x1B[38;5;227m Color 227, \x1B[38;5;228m Color 228, \x1B[38;5;229m Color 229, \x1B[38;5;230m Color 230," +
                "\n\x1B[38;5;231m Color 231, \x1B[38;5;232m Color 232, \x1B[38;5;233m Color 233, \x1B[38;5;234m Color 234, \x1B[38;5;235m Color 235, \x1B[38;5;236m Color 236, \x1B[38;5;237m Color 237, \x1B[38;5;238m Color 238, \x1B[38;5;239m Color 239, \x1B[38;5;240m Color 240," +
                "\n\x1B[38;5;241m Color 241, \x1B[38;5;242m Color 242, \x1B[38;5;243m Color 243, \x1B[38;5;244m Color 244, \x1B[38;5;245m Color 245, \x1B[38;5;246m Color 246, \x1B[38;5;247m Color 247, \x1B[38;5;248m Color 248, \x1B[38;5;249m Color 249, \x1B[38;5;250m Color 250," +
                "\n\x1B[38;5;251m Color 251, \x1B[38;5;252m Color 252, \x1B[38;5;253m Color 253, \x1B[38;5;254m Color 254, \x1B[38;5;255m Color 255");
            LoggerInstance.Msg("--------------------------------------------------------------------------------");
            LoggerInstance.Msg("About to trolly log all 255 Backgrounds to the console!" +
               "\n\x1B[48;5;1m Color 1,   \x1B[48;5;2m Color 2,   \x1B[48;5;3m Color 3,   \x1B[48;5;4m Color 4,   \x1B[48;5;5m Color 5,   \x1B[48;5;6m Color 6,   \x1B[48;5;7m Color 7,   \x1B[48;5;8m Color 8,   \x1B[48;5;9m Color 9,   \x1B[48;5;10m Color 10, \x1B[48;5;0m" +
               "\n\x1B[48;5;11m Color 11,  \x1B[48;5;12m Color 12,  \x1B[48;5;13m Color 13,  \x1B[48;5;14m Color 14,  \x1B[48;5;15m Color 15,  \x1B[48;5;16m Color 16,  \x1B[48;5;17m Color 17,  \x1B[48;5;18m Color 18,  \x1B[48;5;19m Color 19,  \x1B[48;5;20m Color 20, \x1B[48;5;0m" +
               "\n\x1B[48;5;21m Color 21,  \x1B[48;5;22m Color 22,  \x1B[48;5;23m Color 23,  \x1B[48;5;24m Color 24,  \x1B[48;5;25m Color 25,  \x1B[48;5;26m Color 26,  \x1B[48;5;27m Color 27,  \x1B[48;5;28m Color 28,  \x1B[48;5;29m Color 29,  \x1B[48;5;30m Color 30, \x1B[48;5;0m" +
               "\n\x1B[48;5;31m Color 31,  \x1B[48;5;32m Color 32,  \x1B[48;5;33m Color 33,  \x1B[48;5;34m Color 34,  \x1B[48;5;35m Color 35,  \x1B[48;5;36m Color 36,  \x1B[48;5;37m Color 37,  \x1B[48;5;48m Color 38,  \x1B[48;5;39m Color 39,  \x1B[48;5;40m Color 40, \x1B[48;5;0m" +
               "\n\x1B[48;5;41m Color 41,  \x1B[48;5;42m Color 42,  \x1B[48;5;43m Color 43,  \x1B[48;5;44m Color 44,  \x1B[48;5;45m Color 45,  \x1B[48;5;46m Color 46,  \x1B[48;5;47m Color 47,  \x1B[48;5;48m Color 48,  \x1B[48;5;49m Color 49,  \x1B[48;5;50m Color 50, \x1B[48;5;0m" +
               "\n\x1B[48;5;51m Color 51,  \x1B[48;5;52m Color 52,  \x1B[48;5;53m Color 53,  \x1B[48;5;54m Color 54,  \x1B[48;5;55m Color 55,  \x1B[48;5;56m Color 56,  \x1B[48;5;57m Color 57,  \x1B[48;5;58m Color 58,  \x1B[48;5;59m Color 59,  \x1B[48;5;60m Color 60, \x1B[48;5;0m" +
               "\n\x1B[48;5;61m Color 61,  \x1B[48;5;62m Color 62,  \x1B[48;5;63m Color 63,  \x1B[48;5;64m Color 64,  \x1B[48;5;65m Color 65,  \x1B[48;5;66m Color 66,  \x1B[48;5;67m Color 67,  \x1B[48;5;68m Color 68,  \x1B[48;5;69m Color 69,  \x1B[48;5;70m Color 70, \x1B[48;5;0m" +
               "\n\x1B[48;5;71m Color 71,  \x1B[48;5;72m Color 72,  \x1B[48;5;73m Color 73,  \x1B[48;5;74m Color 74,  \x1B[48;5;75m Color 75,  \x1B[48;5;76m Color 76,  \x1B[48;5;77m Color 77,  \x1B[48;5;78m Color 78,  \x1B[48;5;79m Color 79,  \x1B[48;5;80m Color 80, \x1B[48;5;0m" +
               "\n\x1B[48;5;81m Color 81,  \x1B[48;5;82m Color 82,  \x1B[48;5;83m Color 83,  \x1B[48;5;84m Color 84,  \x1B[48;5;85m Color 85,  \x1B[48;5;86m Color 86,  \x1B[48;5;87m Color 87,  \x1B[48;5;88m Color 88,  \x1B[48;5;89m Color 89,  \x1B[48;5;90m Color 90, \x1B[48;5;0m" +
               "\n\x1B[48;5;91m Color 91,  \x1B[48;5;92m Color 92,  \x1B[48;5;93m Color 93,  \x1B[48;5;94m Color 94,  \x1B[48;5;95m Color 95,  \x1B[48;5;96m Color 96,  \x1B[48;5;97m Color 97,  \x1B[48;5;98m Color 98,  \x1B[48;5;99m Color 99,  \x1B[48;5;100m Color 100, \x1B[48;5;0m" +
               "\n\x1B[48;5;111m Color 111, \x1B[48;5;112m Color 112, \x1B[48;5;113m Color 113, \x1B[48;5;114m Color 114, \x1B[48;5;115m Color 115, \x1B[48;5;116m Color 116, \x1B[48;5;117m Color 117, \x1B[48;5;118m Color 118, \x1B[48;5;119m Color 119, \x1B[48;5;120m Color 120, \x1B[48;5;0m" +
               "\n\x1B[48;5;121m Color 121, \x1B[48;5;122m Color 122, \x1B[48;5;123m Color 123, \x1B[48;5;124m Color 124, \x1B[48;5;125m Color 125, \x1B[48;5;126m Color 126, \x1B[48;5;127m Color 127, \x1B[48;5;128m Color 128, \x1B[48;5;129m Color 129, \x1B[48;5;130m Color 130, \x1B[48;5;0m" +
               "\n\x1B[48;5;131m Color 131, \x1B[48;5;132m Color 132, \x1B[48;5;133m Color 133, \x1B[48;5;134m Color 134, \x1B[48;5;135m Color 135, \x1B[48;5;136m Color 136, \x1B[48;5;137m Color 137, \x1B[48;5;148m Color 148, \x1B[48;5;139m Color 139, \x1B[48;5;140m Color 140, \x1B[48;5;0m" +
               "\n\x1B[48;5;141m Color 141, \x1B[48;5;142m Color 142, \x1B[48;5;143m Color 143, \x1B[48;5;144m Color 144, \x1B[48;5;145m Color 145, \x1B[48;5;146m Color 146, \x1B[48;5;147m Color 147, \x1B[48;5;148m Color 148, \x1B[48;5;149m Color 149, \x1B[48;5;150m Color 150, \x1B[48;5;0m" +
               "\n\x1B[48;5;161m Color 161, \x1B[48;5;162m Color 162, \x1B[48;5;163m Color 163, \x1B[48;5;164m Color 164, \x1B[48;5;165m Color 165, \x1B[48;5;166m Color 166, \x1B[48;5;167m Color 167, \x1B[48;5;168m Color 168, \x1B[48;5;169m Color 169, \x1B[48;5;170m Color 170, \x1B[48;5;0m" +
               "\n\x1B[48;5;171m Color 171, \x1B[48;5;172m Color 172, \x1B[48;5;173m Color 173, \x1B[48;5;174m Color 174, \x1B[48;5;175m Color 175, \x1B[48;5;176m Color 176, \x1B[48;5;177m Color 177, \x1B[48;5;178m Color 178, \x1B[48;5;179m Color 179, \x1B[48;5;180m Color 180, \x1B[48;5;0m" +
               "\n\x1B[48;5;181m Color 181, \x1B[48;5;182m Color 182, \x1B[48;5;183m Color 183, \x1B[48;5;184m Color 184, \x1B[48;5;185m Color 185, \x1B[48;5;186m Color 186, \x1B[48;5;187m Color 187, \x1B[48;5;188m Color 188, \x1B[48;5;189m Color 189, \x1B[48;5;190m Color 190, \x1B[48;5;0m" +
               "\n\x1B[48;5;191m Color 191, \x1B[48;5;192m Color 192, \x1B[48;5;193m Color 193, \x1B[48;5;194m Color 194, \x1B[48;5;195m Color 195, \x1B[48;5;196m Color 196, \x1B[48;5;197m Color 197, \x1B[48;5;198m Color 198, \x1B[48;5;199m Color 199, \x1B[48;5;200m Color 200, \x1B[48;5;0m" +
               "\n\x1B[48;5;211m Color 211, \x1B[48;5;212m Color 212, \x1B[48;5;213m Color 213, \x1B[48;5;214m Color 214, \x1B[48;5;215m Color 215, \x1B[48;5;216m Color 216, \x1B[48;5;217m Color 217, \x1B[48;5;218m Color 218, \x1B[48;5;219m Color 219, \x1B[48;5;220m Color 220, \x1B[48;5;0m" +
               "\n\x1B[48;5;221m Color 221, \x1B[48;5;222m Color 222, \x1B[48;5;223m Color 223, \x1B[48;5;224m Color 224, \x1B[48;5;225m Color 225, \x1B[48;5;226m Color 226, \x1B[48;5;227m Color 227, \x1B[48;5;228m Color 228, \x1B[48;5;229m Color 229, \x1B[48;5;230m Color 230, \x1B[48;5;0m" +
               "\n\x1B[48;5;231m Color 231, \x1B[48;5;232m Color 232, \x1B[48;5;233m Color 233, \x1B[48;5;234m Color 234, \x1B[48;5;235m Color 235, \x1B[48;5;236m Color 236, \x1B[48;5;237m Color 237, \x1B[48;5;248m Color 248, \x1B[48;5;239m Color 239, \x1B[48;5;240m Color 240, \x1B[48;5;0m" +
               "\n\x1B[48;5;241m Color 241, \x1B[48;5;242m Color 242, \x1B[48;5;243m Color 243, \x1B[48;5;244m Color 244, \x1B[48;5;245m Color 245, \x1B[48;5;246m Color 246, \x1B[48;5;247m Color 247, \x1B[48;5;248m Color 248, \x1B[48;5;249m Color 249, \x1B[48;5;250m Color 250, \x1B[48;5;0m" +
               "\n\x1B[48;5;251m Color 251, \x1B[48;5;252m Color 252, \x1B[48;5;253m Color 253, \x1B[48;5;254m Color 254, \x1B[48;5;255m Color 255 \x1B[48;5;0m");
            LoggerInstance.Msg("--------------------------------------------------------------------------------");

        }
    }
}