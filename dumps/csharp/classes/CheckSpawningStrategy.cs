using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckSpawningStrategy : PreventionConditionAbstract
	{
		private CHandle<AIArgumentMapping> _spawningStrategyToCompare;
		private CInt32 _spawningStrategyToCompareAsInt;
		private CHandle<PreventionSystem> _system;
		private wCHandle<vehicleBaseObject> _vehicle;

		[Ordinal(0)] 
		[RED("spawningStrategyToCompare")] 
		public CHandle<AIArgumentMapping> SpawningStrategyToCompare
		{
			get => GetProperty(ref _spawningStrategyToCompare);
			set => SetProperty(ref _spawningStrategyToCompare, value);
		}

		[Ordinal(1)] 
		[RED("spawningStrategyToCompareAsInt")] 
		public CInt32 SpawningStrategyToCompareAsInt
		{
			get => GetProperty(ref _spawningStrategyToCompareAsInt);
			set => SetProperty(ref _spawningStrategyToCompareAsInt, value);
		}

		[Ordinal(2)] 
		[RED("system")] 
		public CHandle<PreventionSystem> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		[Ordinal(3)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		public CheckSpawningStrategy(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
