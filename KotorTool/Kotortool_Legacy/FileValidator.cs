using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public sealed class FileValidator 
{
        
        
    private byte[] _key;

    public void Init(string key) => _key = Convert.FromBase64String(key);

    public string GenerateBase64Key(string ClearTextKey) =>
        Convert.ToBase64String(new ASCIIEncoding().GetBytes(ClearTextKey));

    public bool Validate(string filePath, string signature)
    {
            byte[] secondKey = Convert.FromBase64String(signature);
            FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
            keyedHashAlgorithm.Key = _key;
            byte[] hash = keyedHashAlgorithm.ComputeHash(inputStream);
            inputStream.Close();
            return CompareKeys(hash, secondKey);
        }
    /*public Result<string> SignWithResult(string filePath, string key)
    {

        FileStream inputStream = null;

        byte[] hash = { };

        try
        {
            inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
            keyedHashAlgorithm.Key = Convert.FromBase64String(key);
            hash = keyedHashAlgorithm.ComputeHash(inputStream);

        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Console.WriteLine(ex.ToString());
            ProjectData.ClearProjectError();

        }
        finally
        {
            inputStream?.Close();
        }

        return Convert.ToBase64String(hash);
    }*/
        
        
    public string Sign(string filepath, string key)
    {
            
            FileStream inputStream = null;
            byte[] hash = { };
            try
            {
                inputStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
                KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
                keyedHashAlgorithm.Key = Convert.FromBase64String(key);
                hash = keyedHashAlgorithm.ComputeHash(inputStream);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Console.WriteLine(ex.ToString());
                ProjectData.ClearProjectError();
            }
            finally
            {
                inputStream?.Close();
            }

            return Convert.ToBase64String(hash);
        }

    private static bool CompareKeys(IReadOnlyList<byte> firstKey, IReadOnlyList<byte> secondKey)
    {
            if (firstKey == null) throw new ArgumentNullException(nameof(firstKey));
            if (secondKey == null) throw new ArgumentNullException(nameof(secondKey));


            if (firstKey.Count != secondKey.Count)
                return false;
            
            var num = checked(firstKey.Count - 1);
            var index = 0;
            while (index <= num)
            {
                if (firstKey[index] != secondKey[index])
                    return false;
                checked
                {
                    ++index;
                }
            }

            return true;
        }
}