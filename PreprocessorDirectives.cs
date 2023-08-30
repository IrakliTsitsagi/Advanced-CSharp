#define underDev // es  tu wavshale warning amovardeba
#pragma warning disable // amit warningebs shli xelovnurad
namespace PreprocessorDirectives
{
    internal class PreprocessorDirectives
    {
        static void Main(string[] args)
        {
            // #define #if #else #endif #warning #error #pragma warning disable
            int x; // magalitad es xo warnings idzleva value ar aqvs arc gamoyenebulia sadmeo
            #region
            // this is just a simple
            //var name = "";
            #endregion

#if (underDev)
            Console.WriteLine("this app is under development");
            //#error this app is not yet finished ... es ar gaushvebs da errors sheqmni xelovnurad
#else
global::System.Console.WriteLine("this app is complete");
#warning this app is complete and ready to be published

#endif
        }
    }
}