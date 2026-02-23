using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalDistanceToLastKnownPosition : PreventionConditionAbstract
	{
		private CHandle<AIArgumentMapping> _desiredDistanceArgument;
		private CFloat _desiredDistance;
		private CHandle<PreventionSystem> _preventionSystem;

		[Ordinal(0)] 
		[RED("desiredDistanceArgument")] 
		public CHandle<AIArgumentMapping> DesiredDistanceArgument
		{
			get => GetProperty(ref _desiredDistanceArgument);
			set => SetProperty(ref _desiredDistanceArgument, value);
		}

		[Ordinal(1)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(2)] 
		[RED("preventionSystem")] 
		public CHandle<PreventionSystem> PreventionSystem
		{
			get => GetProperty(ref _preventionSystem);
			set => SetProperty(ref _preventionSystem, value);
		}

		public MinimalDistanceToLastKnownPosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
