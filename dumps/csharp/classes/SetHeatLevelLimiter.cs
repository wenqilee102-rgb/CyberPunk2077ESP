using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetHeatLevelLimiter : gameScriptableSystemRequest
	{
		private CInt32 _heatLevelMin;
		private CInt32 _heatLevelMax;
		private CBool _heatLevelReset;
		private CName _source;

		[Ordinal(0)] 
		[RED("HeatLevelMin")] 
		public CInt32 HeatLevelMin
		{
			get => GetProperty(ref _heatLevelMin);
			set => SetProperty(ref _heatLevelMin, value);
		}

		[Ordinal(1)] 
		[RED("HeatLevelMax")] 
		public CInt32 HeatLevelMax
		{
			get => GetProperty(ref _heatLevelMax);
			set => SetProperty(ref _heatLevelMax, value);
		}

		[Ordinal(2)] 
		[RED("HeatLevelReset")] 
		public CBool HeatLevelReset
		{
			get => GetProperty(ref _heatLevelReset);
			set => SetProperty(ref _heatLevelReset, value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetHeatLevelLimiter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
