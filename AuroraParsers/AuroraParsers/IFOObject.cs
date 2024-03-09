namespace AuroraParsers.AuroraParsers
{
    public class IFOObject(AuroraFile file)
    {

        AuroraFile file = file;
        BinaryReader Reader;

        public void Read()
        {
            file.Open();
            Reader = file.GetReader();




            file.Close();
        }

    }
}
