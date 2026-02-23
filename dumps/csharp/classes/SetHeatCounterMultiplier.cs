using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetHeatCounterMultiplier : gameScriptableSystemRequest
	{
		private CFloat _heatMultiplier;
		private CBool _reset;
		private CName _source;

		[Ordinal(0)] 
		[RED("heatMultiplier")] 
		public CFloat HeatMultiplier
		{
			get => GetProperty(ref _heatMultiplier);
			set => SetProperty(ref _heatMultiplier, value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetHeatCounterMultiplier(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
