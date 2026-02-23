using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SniperNestDeviceBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isInTheSniperNest;
		private gamebbScriptID_Bool _fastForwardToZoom4;
		private gamebbScriptID_Float _sniperNestDefaultSpeedMultiplier;
		private gamebbScriptID_Float _sniperNestZoomedSpeedMultiplier;

		[Ordinal(0)] 
		[RED("IsInTheSniperNest")] 
		public gamebbScriptID_Bool IsInTheSniperNest
		{
			get => GetProperty(ref _isInTheSniperNest);
			set => SetProperty(ref _isInTheSniperNest, value);
		}

		[Ordinal(1)] 
		[RED("FastForwardToZoom4")] 
		public gamebbScriptID_Bool FastForwardToZoom4
		{
			get => GetProperty(ref _fastForwardToZoom4);
			set => SetProperty(ref _fastForwardToZoom4, value);
		}

		[Ordinal(2)] 
		[RED("SniperNestDefaultSpeedMultiplier")] 
		public gamebbScriptID_Float SniperNestDefaultSpeedMultiplier
		{
			get => GetProperty(ref _sniperNestDefaultSpeedMultiplier);
			set => SetProperty(ref _sniperNestDefaultSpeedMultiplier, value);
		}

		[Ordinal(3)] 
		[RED("SniperNestZoomedSpeedMultiplier")] 
		public gamebbScriptID_Float SniperNestZoomedSpeedMultiplier
		{
			get => GetProperty(ref _sniperNestZoomedSpeedMultiplier);
			set => SetProperty(ref _sniperNestZoomedSpeedMultiplier, value);
		}

		public SniperNestDeviceBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
