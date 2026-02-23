using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExecuteVisualCustomizationWithDelay : redEvent
	{
		private VehicleVisualCustomizationTemplate _template;
		private CBool _reset;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
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

		public ExecuteVisualCustomizationWithDelay(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
