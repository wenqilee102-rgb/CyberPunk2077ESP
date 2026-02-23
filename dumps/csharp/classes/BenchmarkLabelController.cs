using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BenchmarkLabelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelWidget;
		private inkTextWidgetReference _valueWidget;

		[Ordinal(1)] 
		[RED("labelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get => GetProperty(ref _labelWidget);
			set => SetProperty(ref _labelWidget, value);
		}

		[Ordinal(2)] 
		[RED("valueWidget")] 
		public inkTextWidgetReference ValueWidget
		{
			get => GetProperty(ref _valueWidget);
			set => SetProperty(ref _valueWidget, value);
		}

		public BenchmarkLabelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
