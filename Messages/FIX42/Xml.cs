// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Xml : Message
        {
            public const string MsgType = "n";

            public Xml() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("n"));
            }
        }
    }
}
