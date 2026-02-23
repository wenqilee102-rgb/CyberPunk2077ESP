using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTRavelSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _destinationPoint;
		private gamebbScriptID_Variant _startingPoint;
		private gamebbScriptID_Bool _fastTravelStarted;
		private gamebbScriptID_Bool _fastTravelLoadingScreenStarted;
		private gamebbScriptID_Bool _fastTravelLoadingScreenFinished;
		private gamebbScriptID_EntityID _lastSubwayGateUsed;

		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get => GetProperty(ref _destinationPoint);
			set => SetProperty(ref _destinationPoint, value);
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get => GetProperty(ref _startingPoint);
			set => SetProperty(ref _startingPoint, value);
		}

		[Ordinal(2)] 
		[RED("FastTravelStarted")] 
		public gamebbScriptID_Bool FastTravelStarted
		{
			get => GetProperty(ref _fastTravelStarted);
			set => SetProperty(ref _fastTravelStarted, value);
		}

		[Ordinal(3)] 
		[RED("FastTravelLoadingScreenStarted")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenStarted
		{
			get => GetProperty(ref _fastTravelLoadingScreenStarted);
			set => SetProperty(ref _fastTravelLoadingScreenStarted, value);
		}

		[Ordinal(4)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get => GetProperty(ref _fastTravelLoadingScreenFinished);
			set => SetProperty(ref _fastTravelLoadingScreenFinished, value);
		}

		[Ordinal(5)] 
		[RED("LastSubwayGateUsed")] 
		public gamebbScriptID_EntityID LastSubwayGateUsed
		{
			get => GetProperty(ref _lastSubwayGateUsed);
			set => SetProperty(ref _lastSubwayGateUsed, value);
		}

		public FastTRavelSystemDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
