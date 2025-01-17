﻿using System.Text;
using ExcelDataReader.Core.NumberFormat;

namespace ExcelDataReader.Core.CsvFormat;

internal sealed class CsvWorkbook(Stream stream, Encoding encoding, char[] autodetectSeparators, int analyzeInitialCsvRows, char? quoteChar = null) : IWorkbook<CsvWorksheet>
{
    public int ResultsCount => 1;

    public int ActiveSheet => 0;

    public Stream Stream { get; } = stream;

    public Encoding Encoding { get; } = encoding;

    public char? QuoteChar { get; } = quoteChar;

    public char[] AutodetectSeparators { get; } = autodetectSeparators;

    public int AnalyzeInitialCsvRows { get; } = analyzeInitialCsvRows;

    public IEnumerable<CsvWorksheet> ReadWorksheets()
    {
        yield return new CsvWorksheet(Stream, Encoding, AutodetectSeparators, AnalyzeInitialCsvRows, QuoteChar);
    }

    public NumberFormatString GetNumberFormatString(int index)
    {
        return null;
    }
}