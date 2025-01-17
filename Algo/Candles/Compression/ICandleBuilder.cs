namespace StockSharp.Algo.Candles.Compression
{
	using System;

	/// <summary>
	/// ��������� ����������� ������.
	/// </summary>
	public interface ICandleBuilder : ICandleManagerSource
	{
		/// <summary>
		/// ��� �����.
		/// </summary>
		Type CandleType { get; }

		/// <summary>
		/// ��������� ������.
		/// </summary>
		ICandleBuilderSourceList Sources { get; }

		/// <summary>
		/// K�������� ������.
		/// </summary>
		ICandleBuilderContainer Container { get; }

		/// <summary>
		/// ���������� ����� ������.
		/// </summary>
		/// <param name="series">����� ������.</param>
		/// <param name="currentCandle">������� �����.</param>
		/// <param name="value">����� ������, � ������� ������� ����������� ������� � ������������� ������ ��� ��������� ������������ ������� �����.</param>
		/// <returns>����� �����. ���� ����� ����� ��� ������������� ���������, �� ������������ <paramref name="currentCandle"/>.
		/// ���� ����� ����� ������� ���������� (<paramref name="value"/> �� ����� ���� ��������� � ������), �� ������������ <see langword="null"/>.</returns>
		Candle ProcessValue(CandleSeries series, Candle currentCandle, ICandleBuilderSourceValue value);
	}
}