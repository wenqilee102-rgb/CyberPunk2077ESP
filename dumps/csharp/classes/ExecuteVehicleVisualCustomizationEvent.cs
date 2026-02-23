using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExecuteVehicleVisualCustomizationEvent : redEvent
	{
		private CBool _set;
		private CBool _reset;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(2)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		public ExecuteVehicleVisualCustomizationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
