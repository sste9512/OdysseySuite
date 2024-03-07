namespace Kotortool_Legacy.API.AuroraParsers
{
    public class IFOObject
    {

        AuroraFile file;
        BinaryReader Reader;

        public IFOObject(AuroraFile file)
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
