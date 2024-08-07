using System;
namespace ClassObj
{
	public class Araba
	{
		public string _marka;
		public string _model;
		public string _renk;
		private int _kapiSayisi;

		public int KapiSayisi
		{
			get
			{
				return _kapiSayisi;
			}
			set
			{
				if (value == 2 || value == 4)
				{

					_kapiSayisi = value;
				}
				else
				{
					Console.WriteLine("Gecersiz kapi sayisi.");
					_kapiSayisi = -1;
				}
						
			}
		}
	public void Ozet()
		{
			Console.WriteLine($"{_kapiSayisi} kapili {_renk} {_marka} {_model}");
		}
	}
}
	








    // Marka, Model, Renk, Kapı Sayısı