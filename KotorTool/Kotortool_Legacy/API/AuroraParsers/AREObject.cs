namespace Kotortool_Legacy.API.AuroraParsers
{
    public class AREObject
    {

        AuroraFile file;
        BinaryReader Reader;

        public AREObject(AuroraFile file)
        {
            this.file = file;
        }

        public void Read()
        {
            file.Open();
            Reader = file.GetReader();




            file.Close();
        }

    }
}
