using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipSettingsListener : userSettingsVarListener
	{
		private wCHandle<ItemTooltipCommonController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<ItemTooltipCommonController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public ItemTooltipSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
