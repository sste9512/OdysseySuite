namespace Kotortool_Legacy.API;

public sealed class ERFLocalizedString
{
    public int LanguageId;
    public int StringSize;
    public char[] StringText;

    public ERFLocalizedString(int languageId, string stringText)
    {
        LanguageId = LanguageId;
        StringSize = stringText.Length;
        this.StringText = stringText.ToCharArray();
    }

    public override string ToString()
    {
        return
            $"{nameof(LanguageId)}: {LanguageId}, {nameof(StringSize)}: {StringSize}, {nameof(StringText)}: {StringText}";
    }
}