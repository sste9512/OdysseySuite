// Decompiled with JetBrains decompiler
// Type: kotor_tool.Crypt
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Kotortool_Legacy.Application.Interfaces;

namespace Kotortool_Legacy.Infrastructure;

public class EncryptionService
{
    private readonly IErrorAggregationStore _errorAggregationStore;
    public byte[] TheKey;
    private byte[] Vector;



    /*public EncryptionService(IErrorAggregationStore errorAggregationStore)
    {
            _errorAggregationStore = errorAggregationStore;
            TheKey = new byte[8]
            {
                136,
                21,
                221,
                65,
                1,
                37,
                byte.MaxValue,
                171
            };
            Vector = new byte[13]
            {
                23,
                100,
                38,
                174,
                24,
                37,
                61,
                65,
                26,
                37,
                byte.MaxValue,
                171,
                224
            };
        }

    public string Encrypt(string inName)
    {
            string str = null;
            try
            {
                byte[] numArray = new byte[4097];
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                MemoryStream memoryStream = new MemoryStream(1024);
                byte[] bytes = asciiEncoding.GetBytes(inName);
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    cryptoServiceProvider.CreateEncryptor(TheKey, Vector), CryptoStreamMode.Write);
                int length = inName.Length;
                cryptoStream.Write(bytes, 0, length);
                cryptoStream.FlushFinalBlock();
                string base64String = Convert.ToBase64String(memoryStream.ToArray());
                cryptoStream.Close();
                str = base64String;
            }
            catch (Exception exception)
            {
               /*ProjectData.SetProjectError(ex);

                rojectData.ClearProjectError();#1#/
                _errorAggregationStore.AddError("Error encrypting string", exception, Array.Empty<string>());
            }

            return str;
        }

    public string Decrypt(string InStr)
    {
            string str = null;
            try
            {
                byte[] buffer1 = Convert.FromBase64String(InStr);
                byte[] buffer2 = new byte[1025];
                MemoryStream memoryStream = new MemoryStream();
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                memoryStream.Write(buffer1, 0, buffer1.Length);
                memoryStream.Seek(0L, SeekOrigin.Begin);
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    cryptoServiceProvider.CreateDecryptor(TheKey, Vector), CryptoStreamMode.Read);
                StringBuilder stringBuilder = new StringBuilder();
                int num1;
                do
                {
                    num1 = cryptoStream.Read(buffer2, 0, 64);
                    int num2 = checked(num1 - 1);
                    int index = 0;
                    while (index <= num2)
                    {
                        stringBuilder.Append(Convert.ToChar(buffer2[index]));
                        checked
                        {
                            ++index;
                        }
                    }
                } while (num1 != 0);

                cryptoStream.Close();
                str = stringBuilder.ToString();
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                ProjectData.ClearProjectError();
                _errorAggregationStore.AddError("Error decrypting string", exception, Array.Empty<string>());
            }

            return str;
        }*/
}