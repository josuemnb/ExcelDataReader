namespace ExcelDataReader.Core.BinaryFormat;

/// <summary>
/// For now QuickTip will do nothing, it seems to have a different.
/// </summary>
internal sealed class XlsBiffQuickTip : XlsBiffRecord
{
    internal XlsBiffQuickTip(byte[] bytes)
        : base(bytes)
    {
    }
}