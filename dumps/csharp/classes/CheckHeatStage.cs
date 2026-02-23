using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckHeatStage : PreventionConditionAbstract
	{
		private CHandle<AIArgumentMapping> _heatStageToCompare;
		private CInt32 _heatStageToCompareAsInteger;
		private CInt32 _currentHeatStageAsInteger;
		private CHandle<PreventionSystem> _system;

		[Ordinal(0)] 
		[RED("heatStageToCompare")] 
		public CHandle<AIArgumentMapping> HeatStageToCompare
		{
			get => GetProperty(ref _heatStageToCompare);
			set => SetProperty(ref _heatStageToCompare, value);
		}

		[Ordinal(1)] 
		[RED("heatStageToCompareAsInteger")] 
		public CInt32 HeatStageToCompareAsInteger
		{
			get => GetProperty(ref _heatStageToCompareAsInteger);
			set => SetProperty(ref _heatStageToCompareAsInteger, value);
		}

		[Ordinal(2)] 
		[RED("currentHeatStageAsInteger")] 
		public CInt32 CurrentHeatStageAsInteger
		{
			get => GetProperty(ref _currentHeatStageAsInteger);
			set => SetProperty(ref _currentHeatStageAsInteger, value);
		}

		[Ordinal(3)] 
		[RED("system")] 
		public CHandle<PreventionSystem> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		public CheckHeatStage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
