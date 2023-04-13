using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW270323
{
	class Computer
	{
		readonly private VideoCard videoCard;
		readonly private RAM ram;
		readonly private Winchester winchester;
		readonly private OpticalDiscReader opticalDiscReader;
		readonly private PowerSupply powerSupply;
		readonly private Sensors sensors;

		public Computer()
		{
			videoCard = new VideoCard();
			ram = new RAM();
			winchester = new Winchester();
			opticalDiscReader = new OpticalDiscReader();
			powerSupply = new PowerSupply();
			sensors = new Sensors();
		}

		public void Start()
		{
			powerSupply.ApplyPower();
			sensors.CheckVoltage();
			sensors.CheckPowerSupplyTemp();
			sensors.CheckVideoCardTemp();
			powerSupply.SupplyPowerToVideoCard();
			videoCard.Start();
			videoCard.CheckConnection();
			sensors.CheckRamTemp();
			powerSupply.SupplyPowerToRam();
			ram.LaunchDevices();
			ram.MemoryAnalysis();
			videoCard.OutputRamData();
			powerSupply.SupplyPowerToDiscReader();
			opticalDiscReader.Start();
			opticalDiscReader.CheckIfDiscPresent();
		}
	}

	class VideoCard
	{
		public void Start()
		{
			Console.WriteLine("Starting video card...");
		}

		public void CheckConnection()
		{
			Console.WriteLine("Checking connection with monitor...");
		}

		public void OutputRamData()
		{
			Console.WriteLine("Outputting data about RAM...");
		}
	}

	class RAM
	{
		public void LaunchDevices()
		{
			Console.WriteLine("Launching devices...");
		}

		public void MemoryAnalysis()
		{
			Console.WriteLine("Analyzing memory...");
		}
	}

	class Winchester
	{

	}

	class OpticalDiscReader
	{
		public void Start()
		{
			Console.WriteLine("Starting optical disc reader...");
		}

		public void CheckIfDiscPresent()
		{
			Console.WriteLine("Checking if disc is present...");
		}
	}

	class PowerSupply
	{
		public void ApplyPower()
		{
			Console.WriteLine("Applying power to power supply...");
		}

		public void SupplyPowerToVideoCard()
		{
			Console.WriteLine("Supplying power to video card...");
		}

		public void SupplyPowerToRam()
		{
			Console.WriteLine("Supplying power to RAM...");
		}

		public void SupplyPowerToDiscReader()
		{
			Console.WriteLine("Supply power to disc reader...");
		}
	}

	class Sensors
	{
		public void CheckVoltage()
		{
			Console.WriteLine("Checking voltage...");
		}

		public void CheckPowerSupplyTemp()
		{
			Console.WriteLine("Checking temperature in power supply...");
		}

		public void CheckVideoCardTemp()
		{
			Console.WriteLine("Checking temperature in video card...");
		}

		public void CheckRamTemp()
		{
			Console.WriteLine("Checking temperature in RAM...");
		}
	}
}
