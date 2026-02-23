using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatSettingsListener : userSettingsVarListener
	{
		private wCHandle<ItemTooltipStatController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<ItemTooltipStatController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public ItemTooltipStatSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
