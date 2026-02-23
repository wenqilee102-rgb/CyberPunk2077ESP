using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleController : inkToggleController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private CInt32 _data;

		[Ordinal(16)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(17)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CInt32 Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public ToggleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
